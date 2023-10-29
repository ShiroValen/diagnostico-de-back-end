let loadMoreBtn = document.querySelector('#load-more');
let currentItem = 8;
let articulosencarro=0;


loadMoreBtn.onclick = () => {
    let boxes = [...document.querySelectorAll('.box-container .box')];
    for (var i = currentItem; i < currentItem + 4 && i < boxes.length; i++) {
        boxes[i].style.display = 'inline-block';
    }
    currentItem += 4;
    if(currentItem >= boxes.length) {
        loadMoreBtn.style.display = 'none'
    }
}

//carrito

const carrito = document.getElementById('carrito');
const elementos1 = document.getElementById('lista-1');
const lista = document.querySelector('#lista-carrito tbody');
const vaciarCarritoBtn = document.getElementById('vaciar-carrito');

cargarEventListeners();

function cargarEventListeners(){
    elementos1.addEventListener('click', comprarElemento);
    carrito.addEventListener('click', eliminarElemento);
    vaciarCarritoBtn.addEventListener('click', vaciarCarrito);
}

function comprarElemento(e) {
    e.preventDefault();
    if(e.target.classList.contains('agregar-carrito')){
        const elemento = e.target.parentElement.parentElement;
        leerDatosElemento(elemento);
    }
}

function leerDatosElemento(elemento){
    const infoElemento = {
        imagen: elemento.querySelector('img').src,
        titulo: elemento.querySelector('h3').textContent,
        precio: elemento.querySelector('.Precio').textContent,
        id: elemento.querySelector('a').getAttribute('data-id')
    }
    insertarCarrito(infoElemento);
    
    
}

function insertarCarrito(elemento) {
    const row = document.createElement('tr');
    row.innerHTML = `
       <td>
        <img src="${elemento.imagen}" width=100 height=150px >
       </td>
       <td>
         ${elemento.titulo}
       </td>
       <td>
         ${elemento.precio}
       </td>
       <td>
       <a herf="#" class="borrar" data-id="${elemento.id}" >X</a>
       </td>
    `;
    lista.appendChild(row);
    let canasta = true
    if (canasta ==false) {
        const enlacePagar = document.getElementById('pagar');
        enlacePagar.classList.remove('enlaceHabilitado'); // Remueve la clase existente
        enlacePagar.classList.add('enlaceDeshabilitado'); // Agrega la nueva clase
        enlacePagar.textContent = '';
} else{
    const enlacePagar = document.getElementById('pagar');
    enlacePagar.classList.remove('enlaceDeshabilitado'); // Remueve la clase existente
    enlacePagar.classList.add('enlaceHabilitado'); // Agrega la nueva clase
    enlacePagar.textContent = 'Pagar';
    articulosencarro = articulosencarro+1;
}
}

function eliminarElemento(e){
    e.preventDefault();
    let elemento,
     elementoId;
    if(e.target.classList.contains('borrar')){
        e.target.parentElement.parentElement.remove();
        elemento = e.target.parentElement.parentElement;
        elementoId = elemento.querySelector('a').getAttribute('data-id');
        articulosencarro = articulosencarro-1;
    }
        if (articulosencarro >0) {
            const enlacePagar = document.getElementById('pagar');
            enlacePagar.classList.remove('enlaceDeshabilitado'); // Remueve la clase existente
            enlacePagar.classList.add('enlaceHabilitado'); // Agrega la nueva clase
            enlacePagar.textContent = 'Pagar';
    } else{
        const enlacePagar = document.getElementById('pagar');
        enlacePagar.classList.remove('enlaceHabilitado'); // Remueve la clase existente
        enlacePagar.classList.add('enlaceDeshabilitado'); // Agrega la nueva clase
        enlacePagar.textContent = '';

    
}
}

function vaciarCarrito(){
    while(lista.firstChild){
        lista.removeChild(lista.firstChild);
    }
    return false;
}

document.getElementById('mitadLink').addEventListener('click', function(event) {
    event.preventDefault();
    // Scroll suave a la mitad de la página cuando se hace clic en el enlace "Productos"
    const mitadElement = document.getElementById('mitad');
    mitadElement.scrollIntoView({
        behavior: 'smooth'
    });
});

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Selecciona todos los botones de agregar y quitar en todos los productos
const botonesAgregar = document.querySelectorAll('.agregar');
const botonesQuitar = document.querySelectorAll('.quitar');
const cantidades = document.querySelectorAll('.cantidad');

// Itera sobre todos los botones de agregar y agrega eventos de clic
botonesAgregar.forEach((botonAgregar, index) => {
    botonAgregar.addEventListener('click', function() {
        // Incrementa la cantidad del producto correspondiente al índice actual
        cantidades[index].textContent = ++cantidad[index];
    });
});

// Itera sobre todos los bo tones de quitar y agrega eventos de clic
botonesQuitar.forEach((botonQuitar, index) => {
    botonQuitar.addEventListener('click', function() {
        // Disminuye la cantidad del producto correspondiente al índice actual
        if (cantidad[index] > 0) {
            cantidades[index].textContent = --cantidad[index];
        }
    });
});
// Inicializa un array para mantener el estado de la cantidad para cada producto
let cantidad = new Array(botonesAgregar.length).fill(0);








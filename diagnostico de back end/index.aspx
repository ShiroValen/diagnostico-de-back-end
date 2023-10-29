<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="diagnostico_de_back_end.index" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Document</title>
    <link rel="stylesheet" href="estilos.css" />
        <script type="text/javascript">
            function ocultarLabel() {
                var label = document.getElementById('<%= lblMensaje.ClientID %>');
            if (label) {
                label.style.display = 'block';
                setTimeout(function () {
                    label.style.display = 'none';
                }, 5000); // 5000 milisegundos = 5 segundos
            }
        }
        </script>
    <script type="text/javascript">
        function soloNumeros(e) {
            var tecla = e.which || e.keyCode;
            if (tecla < 48 || tecla > 57) {
                e.preventDefault();
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <header class="header">
            <div class="menu container">
                <a href="#" class="logo">logo</a>
                <input type="checkbox" id="menu" />
                <label for="menu">
                    <img src="imagenes/menu.png" class="menu-icono" alt="menu" />
                </label>
                <nav class="navbar">
                    <ul>
                        <li><a href="#">Inicio</a></li>
                        <li><a href="Ventas.aspx">Ventas</a></li>
                        <li><a href="#mitad" id="mitadLink">Productos</a></li>
                        <li><a href="#">Contacto</a></li>
                    </ul>
                </nav>

                <div>
                    <ul>
                        <li class="submenu">
                            <img id="img-carrito" src="imagenes/car.svg" alt="car" />
                            <div id="carrito">
                                <table id="lista-carrito">
                                    <thead>
                                        <tr>
                                            <th>Imagen</th>
                                            <th>Nombre</th>
                                            <th>Precio</th>
                                        </tr>
                                    </thead>
                                    <tbody></tbody>
                                </table>
                                <a href="#" id="vaciar-carrito" class="btn-3">Vaciar Carrito</a>
                                <a href="#" id="pagar" class="enlaceDeshabilitado"></a>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="header-content container">
                <div class="header-txt">
                    <span>Bienvenido a mi diagnóstico de back-end</span>
                    <h1>Cafés especiales!</h1>
                    <p>
                        Este sábado de frescura, visita las promociones de 2X1 en todos nuestros cafés. Ven y compra para así poder pagarle a este programador por su diagnóstico de backend.
                    </p>
                    <div class="butons">
                        <a href="#" class="btn-1">Información</a>
                        <a href="#" class="btn-1">Leer más</a>
                    </div>
                </div>
                <div class="header-img">
                    <img src="imagenes/bag.png" alt="" />
                </div>
            </div>
        </header>
        <section class="oferts container">
            <div class="ofert-1 b1">
                <div class="ofert-txt">
                    <h3>Artículos sanos</h3>
                    <a href="#">Leer más</a>
                </div>
                <div class="ofert-img">
                    <img src="imagenes/s1.png" alt="" />
                </div>
            </div>
            <div class="ofert-1 b2">
                <div class="ofert-txt">
                    <h3>Bebidas saludables</h3>
                    <a href="#">Leer más</a>
                </div>
                <div class="ofert-img">
                    <img src="imagenes/s2.png" alt="" />
                </div>
            </div>
            <div class="ofert-1 b3">
                <div class="ofert-txt">
                    <h3>Productos lácteos</h3>
                    <a href="#">Leer más</a>
                </div>
                <div class="ofert-img">
                    <img src="imagenes/s3.png" alt="" />
                </div>
            </div>
        </section>
        <main class="products container">
            <h2>Productos</h2>
            <div class="box-container" id="lista-1">
                <div class="box" id="mitad">
                    <img src="imagenes/pr1.png" alt="" />
                    <div class="product-txt">
                        <h3>Café Moka</h3>
                        <p>Calidad premium</p>
                        <p class="Precio">$20.99</p>
                        <div class="aumento">
                            <button class="quitar">-</button> <%--esteticos--%>
                            <span class="cantidad">1</span>
                            <button class="agregar">+</button>
                        </div>
                        <asp:Button ID="btnMoka" runat="server" Text="Comprar articulo" CssClass="agregar-carrito btn-3" OnClick="Comprar_Click" data-producto="Moka" data-precio="20.99" />
                    </div>
                </div>
                <div class="box" id="mitad">
                    <img src="imagenes/pr2.png" alt="" />
                    <div class="product-txt">
                        <h3>Café Latte</h3>
                        <p>Calidad premium</p>
                        <p class="Precio">$35</p>
                        <div class="aumento">
                            <button class="quitar">-</button> <%--esteticos--%>
                            <span class="cantidad">1</span>
                            <button class="agregar">+</button>
                        </div>
                        <asp:Button ID="btnLatte" runat="server" Text="Comprar articulo" CssClass="agregar-carrito btn-3" OnClick="Comprar_Click" data-producto="Latte" data-precio="35.00" />
                    </div>
                </div>
                <div class="box" id="mitad">
                    <img src="imagenes/pr3.png" alt="" />
                    <div class="product-txt">
                        <h3>Café Americano</h3>
                        <p>Calidad premium</p>
                        <p class="Precio">$25.50</p>
                        <div class="aumento">
                            <button class="quitar">-</button> <%--esteticos--%>
                            <span class="cantidad">1</span>
                            <button class="agregar">+</button>
                        </div>
                    <asp:Button ID="btnAmericano" runat="server" Text="Comprar articulo" CssClass="agregar-carrito btn-3" OnClick="Comprar_Click" data-producto="Americano" data-precio="40.00" />
                    </div>
                </div>
            </div>
        </main>
        <section class="contact container">
            <h2>Contacto</h2><asp:Label ID="lblMensaje" runat="server" ForeColor="Green" CssClass="label-mensaje" Visible="false"></asp:Label>
            <div class="box-container">
                <div class="box">
                    <img src="imagenes/loc.png" alt="" />
                    <h3>Ubicación</h3>
                    <p>Dirección de tu empresa</p>
                </div>
                <div class="box">
                    <img src="imagenes/mail.png" alt="" />
                    <h3>Correo Electrónico</h3>
                    <p>correo@empresa.com</p>
                </div>
                <div class="box">
                    <img src="imagenes/tel.png" alt="" />
                    <h3>Teléfono</h3>
                    <p>+123 456 789</p>
                </div>
                <div class="box">
                    <h2>Iniciar Sesión</h2>
                    <p>Usuario</p>
                    <asp:TextBox ID="txtuser" runat="server" CssClass="input-field"></asp:TextBox>
                    <p>Contraseña</p>
                    <asp:TextBox ID="txtpass" runat="server" CssClass="input-field" onkeypress="soloNumeros(event)" MaxLength="4"></asp:TextBox>
                    <p>ID para cancelar venta</p>
                    <asp:TextBox ID="txtIDVenta" runat="server" CssClass="input-field"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar Sesión" CssClass="btn-3" OnClick="IniciarSesion_Click" />
                </div>
                </div>
        </section>
        <script src="script.js"></script>
    </form>
</body>
</html>

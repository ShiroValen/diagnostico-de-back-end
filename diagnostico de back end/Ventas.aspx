<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="diagnostico_de_back_end.Ventas" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de Ventas</title>
    <link rel="stylesheet" href="estilos.css" />
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
                        <li><a href="index.aspx">Inicio</a></li>
                        <li><a href="ventas.aspx">Ventas</a></li>
                        <li><a href="" id="mitadLink">Productos</a></li>
                        <li><a href="#">Contacto</a></li>
                    </ul>
                </nav>

                <div>
                    <ul>            
                    </ul>
                </div>
            </div>
        </header>

            <table class="tabla-de-ventas">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>ID_Bebida</th>
                    <th>Bebida</th>
                    <th>ID_TipoCafe</th>
                    <th>Fecha de Venta</th>
                    <th>Precio Total</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="ventasRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ID") %></td>
                            <td><%# Eval("ID_Bebida") %></td>
                            <td><%# Eval("Bebida") %></td>
                            <td><%# Eval("ID_TipoCafe") %></td>
                            <td><%# Eval("FechaVenta", "{0:yyyy-MM-dd HH:mm:ss}") %></td>
                            <td><%# Eval("PrecioTotal", "{0:C}") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </form>
</body>
</html>
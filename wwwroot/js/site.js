// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Guardar en SessionStorage
function guardarProducto(nombre, precio) {

    let productos = JSON.parse(sessionStorage.getItem("productos")) || [];

    let comprador = sessionStorage.getItem("comprador");

    productos.push({
        comprador: comprador,
        nombre: nombre,
        precio: precio
    });

    sessionStorage.setItem("productos", JSON.stringify(productos));
}

// Mostrar en consola (para evidencia)
function mostrarProductos() {
    let productos = JSON.parse(sessionStorage.getItem("productos"));

    console.log("Productos en SessionStorage:", productos);
} 
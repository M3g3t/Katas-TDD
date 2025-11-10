using AwesomeAssertions;
using Core.SuperMarket;

namespace Core.Tests;

public class SuperMarketReceiptTests
{
    [Fact]
    public void Si_InicializoCajaRegistradoraElValorAPagar_Debe_Ser0()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.ValorAPagar.Should().Be(0);
    }

    [Fact]
    public void Si_RegistroProductoConPrecio10ElValorAPagar_Debe_Ser10()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.RegistrarProducto(new Producto(TipoProducto.Otro, 10));

        cajaRegistradora.ValorAPagar.Should().Be(10);
    }

    [Fact]
    public void Si_RegistroDosProductosUnoConPrecio5yOtroConPrecio10ElValorAPagar_Debe_Ser15()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.RegistrarProducto(new Producto(TipoProducto.Otro, 5));
        cajaRegistradora.RegistrarProducto(new Producto(TipoProducto.Otro, 10));

        cajaRegistradora.ValorAPagar.Should().Be(15);
    }

    [Fact]
    public void Si_RegistroUnCepilloDentalConPrecio5ElValorAPagar_Debe_Ser5()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.RegistrarProducto(new Producto(TipoProducto.CepilloDental, 5));

        cajaRegistradora.ValorAPagar.Should().Be(5);
    }

    [Fact]
    public void Si_RegistroUnaCremaDentalConPrecio6QueTieneDescuentoDe50PorCientoElValorAPagar_Debe_Ser3()
    {
        var cajaRegistradora = new CajaRegistradora();
        var productoConDescuento = new Producto(TipoProducto.CremaDental, 6);
        
        cajaRegistradora.RegistrarProducto(productoConDescuento);
        
        cajaRegistradora.ValorAPagar.Should().Be(3);
    }

    [Fact]
    public void Si_RegitroUnaBolsaDeArrozYElDescuentoEsDel10Poriciento_Debe_DescontarEl10PorcientoDelValorDelProducto()
    {
        var cajaRegistradora = new CajaRegistradora();
        var productoConDescuento = new Producto(TipoProducto.Arroz, 20);
        
        cajaRegistradora.RegistrarProducto(productoConDescuento);
        
        cajaRegistradora.ValorAPagar.Should().Be(18);
        
    }

    [Fact]
    public void Si_ElDescuentoDelProductoArrozEsDel30Porc_Debe_ElValorAPagarDelProductoArrozTenerDescuentoDel30Porc()
    {
        var porcentajeDescuento = 30M;
        var cajaRegistradora = new CajaRegistradora(new Descuento(TipoProducto.Arroz,porcentajeDescuento));
        var productoConDescuento = new Producto(TipoProducto.Arroz, 20);
        var valorAPagar =  productoConDescuento.Precio - (porcentajeDescuento / 100) *  productoConDescuento.Precio;
        
        cajaRegistradora.RegistrarProducto(productoConDescuento);
        
        cajaRegistradora.ValorAPagar.Should().Be(valorAPagar);
    }
    

}
> [Contexto](https://www.codurance.com/es/katas/kata-cajero-automatico)

# Check List Cajero Automatico

## Casos basicos 
- [x] Si retiro 1, debe mostrar como salida 1 moneda de  valor 1
- [x] Si retiro 2, debe mostrar como salida 1 moneda de  valor 2
- [x] Si retiro 5, debe mostrar como salida 1 billete de  valor 5
- [x] Si retiro 10, debe mostrar como salida 1 billete de  valor  10
- [x] Si retiro 20, debe mostrar como salida 1 billete de  valor  20
- [ ] Si retiro 50, debe mostrar como salida 1 billete de  valor  50
- [ ] Si retiro 100, debe mostrar como salida 1 billete de  valor  100
- [ ] Si retiro 200, debe mostrar como salida 1 billete de  valor  200
- [ ] Si retiro 500, debe mostrar como salida 1 billete de  valor  500
  
  
## Casos complejos 
- [ ] Si retiro 1000, el valor disponible del cajero debe ser 4100
- [ ] Si retiro 1500, el valor disponible del cajero debe ser 3600
- [ ] Si retiro 1000, debe mostrar como salida 2 billetes de valor  500
- [ ] Si retiro 1000, no deben quedar billetes de valor 500
- [ ] Si retiro 1000 y vuelvo a retirar 600, no debe quedar billetes con valor de 500 y 200
- [ ] Si retiro 1600 y vuelvo a retirar 500, no deben quedar billetes con valor de 500 200 y 100
- [ ] Si retiro 2100 y vuelvo a retirar 600, no deben quedar billetes con valor de 500,200,100 y de 50
- [ ] Si retiro 2700 y vuelvo a retirar 400, no deben quedar billetes con valor de 500,200,100,50,20
- [ ] Si retiro 3100 y vuelvo a retirar 500, no deben quedar billetes con valor de 500,200,100,50,20,10
- [ ] Si retiro 3600 y vuelvo a retirar 500, no deben quedar billetes con valor de 500,200,100,50,20,10,5
- [ ] Si retiro 4100 y vuelvo a retirar 500, no deben quedar billetes con valor de 500,200,100,50,20,10,5 ni monedas de 2

- [ ] Si retiro 600, debe mostrar como salida 1 billete de valor 500 y un billete de 100

  
## Casos de borde
- [x] **El dinero disponible inicial del cajero debe ser 5100**
- [ ] Si retiro 0, debe lanzar excepcion por tope minimo excedido
- [ ] Si retiro 5100 el dinero disponible en el cajero debe ser 0
- [ ] Si retiro 5200, debe lanzar excepcion por tope maximo excedido
- [ ] Si no hay dinero disponible, debe lanzar excepcion con el mensaje "El cajero automático no dispone de dinero suficiente, por favor acuda al cajero automático más cercano".
- [ ] 

## Validaciones
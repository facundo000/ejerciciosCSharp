using System;
using System.Collections.Generic;

class Persona
{
    public string Nombre { get; set; }
    public int DNI { get; set; }
    public string Sexo { get; set; }
}

class Cliente : Persona
{
    public int Codigo { get; set; }
    public double LimiteCredito { get; set; }
    public List<Cuenta> Cuentas { get; set; }

    public Cliente(string nombre, int dni, string sexo, int codigo, double limiteCredito)
    {
        Nombre = nombre;
        DNI = dni;
        Sexo = sexo;
        Codigo = codigo;
        LimiteCredito = limiteCredito;
        Cuentas = new List<Cuenta>();
    }

    public void AgregarCuenta(Cuenta cuenta)
    {
        Cuentas.Add(cuenta);
    }
}

class Cuenta
{
    public int Numero { get; set; }
    public int Tipo { get; set; }   
    public double Saldo { get; set; }

    public Cuenta(int numero, int tipo, double saldo)
    {
        Numero = numero;
        Tipo = tipo;
        Saldo = saldo;
    }
}

class Banco
{
    private List<Cliente> clientes;

    public Banco()
    {
        clientes = new List<Cliente>();
    }

    public void AgregarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public void CalcularEstadisticas()
    {
        int cajaAhorro = 0;
        int cuentaCorriente = 0;
        double saldoTotalCajaAhorro = 0;
        double saldoTotalCuentaCorriente = 0;
        int clientesFemeninos = 0;
        Cliente clienteMayorLimiteCredito = null;

        foreach (Cliente cliente in clientes)
        {
            foreach (Cuenta cuenta in cliente.Cuentas)
            {
                if (cuenta.Tipo == 1)
                {
                    cajaAhorro++;
                    saldoTotalCajaAhorro += cuenta.Saldo;
                }
                else
                {
                    cuentaCorriente++;
                    saldoTotalCuentaCorriente += cuenta.Saldo;
                }
            }

            if (cliente.Sexo == "F")
            {
                clientesFemeninos++;
            }

            if (clienteMayorLimiteCredito == null || cliente.LimiteCredito > clienteMayorLimiteCredito.LimiteCredito)
            {
                clienteMayorLimiteCredito = cliente;
            }
        }

        double saldoPromedioCajaAhorro = cajaAhorro > 0 ? saldoTotalCajaAhorro / cajaAhorro : 0;
        double saldoPromedioCuentaCorriente = cuentaCorriente > 0 ? saldoTotalCuentaCorriente / cuentaCorriente : 0;
        double saldoPromedioGeneral = (saldoTotalCajaAhorro + saldoTotalCuentaCorriente) / (cajaAhorro + cuentaCorriente);
        double porcentajeClientesFemeninos = (double)clientesFemeninos / clientes.Count * 100;

        Console.WriteLine("Estadísticas del banco:");
        Console.WriteLine($"Cantidad de cajas de ahorro: {cajaAhorro}");
        Console.WriteLine($"Cantidad de cuentas corrientes: {cuentaCorriente}");
        Console.WriteLine($"Saldo promedio de cajas de ahorro: {saldoPromedioCajaAhorro:F2}");
        Console.WriteLine($"Saldo promedio de cuentas corrientes: {saldoPromedioCuentaCorriente:F2}");
        Console.WriteLine($"Saldo promedio general: {saldoPromedioGeneral:F2}");
        Console.WriteLine($"Porcentaje de clientes femeninos: {porcentajeClientesFemeninos:F2}%");
        Console.WriteLine($"Cliente con mayor límite de crédito: {clienteMayorLimiteCredito.Nombre} (Límite: {clienteMayorLimiteCredito.LimiteCredito:F2})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco();

        // Agregar clientes y cuentas
        Cliente cliente1 = new Cliente("Juan Pérez", 12345678, "M", 1001, 5000.0);
        cliente1.AgregarCuenta(new Cuenta(1001, 1, 2500.0));
        cliente1.AgregarCuenta(new Cuenta(1002, 2, 3000.0));
        banco.AgregarCliente(cliente1);

        Cliente cliente2 = new Cliente("María González", 87654321, "F", 1002, 7000.0);
        cliente2.AgregarCuenta(new Cuenta(2001, 1, 4000.0));
        cliente2.AgregarCuenta(new Cuenta(2002, 2, 6000.0));
        banco.AgregarCliente(cliente2);

        // Calcular y mostrar estadísticas
        banco.CalcularEstadisticas();
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using ClosedXML.Excel;

public class DatabaseHandler
{
    private readonly string connectionString;

    public DatabaseHandler(string server, string database, string username, string password)
    {
        connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
    }

    public DataTable ExecuteQuery(string query)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public void ExportarDataTableAExcel(DataTable dataTable)
    {
        // Crear un nuevo libro de Excel
        using (var workbook = new XLWorkbook())
        {
            // Agregar una hoja de Excel
            var worksheet = workbook.Worksheets.Add("Datos");

            // Agregar los datos del DataTable a la hoja de Excel
            worksheet.Cell(1, 1).InsertTable(dataTable);

            // Guardar el libro de Excel
            workbook.SaveAs("ExportacionDatos.xlsx");
        }
    }
}

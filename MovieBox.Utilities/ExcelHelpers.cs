#region Includes

// .NET Libraries
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

#endregion

namespace Utilities
{
    /// <summary>
    /// Represents helper methods for working with Excel files.
    /// </summary>
    public static class ExcelHelpers
    {
        #region Methods

        public static IEnumerable<DataRow> ImportWorksheet(Dictionary<string, string> values)
        {
            IEnumerable<DataRow> result;

            using (OleDbConnection conn = new OleDbConnection(string.Format(values["ConnString"])))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(values["Query"], conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, values["SourceTable"]);
                    result = ds.Tables[values["SourceTable"]].AsEnumerable();
                }
            }

            return result;
        }

        #endregion
    }
}

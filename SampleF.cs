using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView1
{
    public class SampleF : IDesignTimeDbContextFactory<DataB>
    {
        public DataB CreateDbContext(string[] args)
           => new DataB(DataBaseHalper.Option());
    }
}

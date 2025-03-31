using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportBillDTO
    {
        private int id;
        private string nameProvide;
        private DateTime datein;
        private float toltal;
        private int idProvide;

        public ImportBillDTO() { }

        public ImportBillDTO(int id, string nameProvide, DateTime datein, float toltal, int idProvide)
        {
            this.Id = id;
            this.NameProvide = nameProvide;
            this.Datein = datein;
            this.Toltal = toltal;
            this.idProvide = idProvide;
        }

        public int Id { get => id; set => id = value; }
        public string NameProvide { get => nameProvide; set => nameProvide = value; }
        public DateTime Datein { get => datein; set => datein = value; }
        public float Toltal { get => toltal; set => toltal = value; }

        public int IdProvide { get => idProvide; set => idProvide = value; }
    }
}

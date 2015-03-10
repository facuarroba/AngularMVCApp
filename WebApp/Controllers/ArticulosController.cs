using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{

    public class ArticulosController : ApiController
    {
        // GET api/articulos
        public IEnumerable<Articulo> Get()
        {
            return demo();
        }

        // GET api/articulos/5
        public Articulo Get(int id)
        {
            Articulo[] arts = demo();
            return arts[id];
        }

        public Articulo Get(string codigo)
        {
            Articulo[] arts = demo();
            return Array.Find(arts,a => a.Codigo.Equals(codigo));
        }

        // POST api/articulos
        public void Post([FromBody]string value)
        {
        }

        // PUT api/articulos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/articulos/5
        public void Delete(int id)
        {
        }

        private Articulo[] demo()
        {
            Articulo[] arts = new Articulo[25];
            arts[0] = new Articulo("7793360986208", "Jardinera", "Jardinera de hortalizas y legumbres, libre de gluten", "La Campagnola", "300", "g", "Argentina","12.50");
            arts[1] = new Articulo("7793360984808", "Choclo Entero", "Granos de choclo amarillo, grano entero, libre de gluten", "La Campagnola", "240", "g", "Argentina", "13.75");
            arts[2] = new Articulo("7793360984907", "Choclo Cremoso", "Granos de choclo amarillo, tipo cremoso, libre de gluten", "La Campagnola", "300", "g", "Argentina","10");
            arts[3] = new Articulo("7793360811401", "Mermelada BC Durazno", "Mermelada de durazno, reducida en calorias, libre de gluten", "La Campagnola", "390", "g", "Argentina", "17");
            arts[4] = new Articulo("7793360826306", "Mermelada BC Frutos Rojos", "Mermelada de cassis, frutilla y mora, reducida en calorias, libre de gluten", "La Campagnola", "390", "g", "Argentina", "19");
            arts[5] = new Articulo("7801810712830", "Te en saquitos", "Yellow label tea", "Lipton", "50", "u", "Argentina", "20");
            arts[6] = new Articulo("7791004000082", "Sal gruesa", "Sal gruesa libre de gluten, sin TACC", "Celusal", "1", "kg", "Argentina", "11");
            arts[7] = new Articulo("7790072002080", "Sal fina", "Sal fina corrediza, libre de gluten, sin TACC", "Celusal", "500", "g", "Argentina", "10");
            arts[8] = new Articulo("7791880001616", "Arroz Carnaroli", "Arroz gallo variedades especiales. Ideal para prepar risottos", "Gallo", "500", "g", "Argentina", "23");
            arts[9] = new Articulo("7791880000428", "Arroz ", "Oro. No se pasa ni se pega", "Gallo", "1", "kg", "Argentina", "20");
            arts[10] = new Articulo("7794000598935", "Pomarola con albahaca", "Salsa lista pomarola.", "Knorr", "340", "g", "Argentina", "18");
            arts[11] = new Articulo("7790070411488", "Preferido", "Pan rallado", "Lucchetti", "500", "g", "Argentina", "21");
            arts[12] = new Articulo("7790150696804", "Cafe molito. Torrado", "Cafe tostado con azucar blanco molido", "La virginia", "500", "g", "Argentina", "40");
            arts[13] = new Articulo("7790790019063", "Pure de tomates", "", "Inca", "520", "g", "Argentina", "14");
            arts[14] = new Articulo("7793360000485", "Pure de tomate", "", "La Campagnola", "520", "g", "Argentina", "17");
            arts[15] = new Articulo("7790088001497", "Pure de tomates", "", "Alco", "520", "g", "Argentina", "14.5");
            arts[16] = new Articulo("7790150696057", "Salsa 4 quesos ", "Polvo para preparar salsa 4 quesos", "Alicante", "37", "g", "Argentina", "18");
            arts[17] = new Articulo("7794000596184", "Caldo de verdura", "Estuche de cubitos", "Knorr", "10", "u", "Argentina", "22");
            arts[18] = new Articulo("7794000596177", "Caldo de verdura", "cubitos", "Knorr", "6", "u", "Argentina", "16");
            arts[19] = new Articulo("7791620002279", "Mayonesa d' fiesta", "", "Danica", "250", "cm3", "Argentina", "12.5");
            arts[20] = new Articulo("7613034294814", "Pure de la huerta alos 4 quesos", "", "Maggi", "150", "g", "Argentina", "20");
            arts[21] = new Articulo("7791620002019", "Mostaza", "Aderezo a base de mostaza", "Danica", "220", "g", "Argentina", "12.5");
            arts[22] = new Articulo("7791620002453", "Ketchup", "Aderezo a base de ketchup", "Danica", "220", "g", "Argentina", "12.5");
            arts[23] = new Articulo("7794000598065", "Maizena", "Almidon de maiz", "Maizena", "500", "g", "Argentina", "25");
            arts[24] = new Articulo("7798031154115", "Fideos tirabuzon", "", "Knorr", "500", "g", "", "11");
            return arts;
        }

    }
}

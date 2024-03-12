using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Request;

namespace WebApplication1.Service
{
    public class NotaService : ControllerBase, INota
    {
       

        public ActionResult getNota()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.Nota.ToList();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult postNota([FromBody] NotaRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Notum nota = new Models.Notum();
                    nota.Nombre = request.nombre;
                    nota.Nota1 = request.nota1;
                    nota.Nota2 = request.nota2;
                    nota.Resultado = nota.Nota1 + nota.Nota2;
                    nota.Fecha = Convert.ToString(request.fecha.ToLocalTime());
                    db.Nota.Add(nota);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult putNota(int id, [FromBody] NotaRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Notum nota = db.Nota.Find(id);
                    nota.Nombre = request.nombre;
                    nota.Nota1 = request.nota1;
                    nota.Nota2 = request.nota2;
                    nota.Resultado = nota.Nota1 + nota.Nota2;
                    db.Entry(nota).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return Ok("Se edito correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult deleteNota(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Notum nota = db.Nota.Find(id);
                    db.Nota.Remove(nota);
                    db.SaveChanges();
                    return Ok("Se elimino correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

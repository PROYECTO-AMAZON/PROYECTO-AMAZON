using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_AMAZON.Models;
using PROYECTO_AMAZON.Data;
using System.Dynamic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace PROYECTO_AMAZON.Controllers;

public class CarreraController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _um;

    public CarreraController(ApplicationDbContext context,UserManager<IdentityUser> um)
    {
        _context = context;
        _um = um;
    }

    public IActionResult Index()
    {
        return View();
    }    

    [HttpPost]
    public IActionResult Index(string fecCarrera, string semana, double distancia, double tiempo)
    {                
            if (ModelState.IsValid){
                CARRERA objCarrera=new CARRERA();
                objCarrera.fecCarrera=fecCarrera;
                objCarrera.semana=semana;
                objCarrera.distancia=distancia;
                objCarrera.tiempo=tiempo;

                // ALUMNO objALUMNO= _context.ALUMNOs.Where(m => m.email == User.Identity.Name).FirstOrDefault();
                // var nomUsu=objALUMNO.nombre;
                // var apeUsu=objALUMNO.apePat;

                objCarrera.nombre_particpante=User.Identity.Name;               
                
                var url = "https://functionsaws.azurewebsites.net/api/InsertCarrera?code=gWn0Qf8Y-WvVPSQM7CxKZzzwz-yqwPf3DNon-Oxl3L4AAzFulx2sHA==";



                using (var httpClient = new HttpClient()){

                var respuesta = httpClient.PostAsJsonAsync(url, objCarrera);

                }
                
                _context.Add(objCarrera);
                _context.SaveChanges();                  
            }      
        
       return RedirectToAction("Principal");
        
    }        
    
    public IActionResult Principal()
    {   
        var lista=_context.CARRERAs.ToList();
            return View(lista);
    }

    private bool CarreraExists(int id)
    {
        return _context.CARRERAs.Any(e => e.id == id);
    }

    public IActionResult Edit(int id)
    {
        CARRERA objCARRERA = _context.CARRERAs.Find(id);
        if(objCARRERA == null){
            return NotFound();
        }
        return View(objCARRERA);
    }

    [HttpPost]
    public IActionResult Edit(int id,CARRERA objCARRERA)
    {   
        objCARRERA.nombre_particpante=User.Identity.Name;
        _context.Update(objCARRERA);
        _context.SaveChanges();
        return RedirectToAction(nameof(Principal));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
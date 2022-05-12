using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_AMAZON.Models;
using PROYECTO_AMAZON.Data;
using Microsoft.AspNetCore.Identity;

namespace PROYECTO_AMAZON.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _um;
    private readonly SignInManager<IdentityUser> _sim;

    public HomeController(ApplicationDbContext context,UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
    {
        _context = context;
        _um = um;
        _sim = sim;
    }

    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(ALUMNO objUsuario)
    {
        if (ModelState.IsValid) {

            _context.Add(objUsuario);
            _context.SaveChanges();

            var correo = objUsuario.email;
            var password =objUsuario.contrasena;

            var user = new IdentityUser{UserName = correo, Email = correo};
            var result = _um.CreateAsync(user, password).Result;
            // Guardar en BD
             if (result.Succeeded){
                    return RedirectToAction("Login");
            }        
            
        }

        return View("Form",objUsuario);
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(string email, string contrasena)
    {
        var result = _sim.PasswordSignInAsync(email, contrasena, false, false).Result;

        if (result.Succeeded) {
            return RedirectToAction("Principal");
        } 

        ModelState.AddModelError("", " Email y/o contraseña incorrectos");

        return View();
    }

    public async Task<IActionResult> Logout()
    {
        await _sim.SignOutAsync();

        return RedirectToAction("Login");
    } 

    public IActionResult Principal()
    {
        if (User.Identity.IsAuthenticated){
                ALUMNO objALUMNO=new ALUMNO();
                objALUMNO= _context.ALUMNOs.Where(m => m.email == User.Identity.Name).FirstOrDefault();
                var nomUsu=objALUMNO.nombre;
                objALUMNO.nombre=nomUsu;

                return View("Principal",objALUMNO);
            }
            return View();
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

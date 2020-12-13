
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class DepartmentController: Controller
{
    private readonly EMSContext db;

    public DepartmentController(EMSContext _db)
   {
        db = _db;
    }
     
    public ActionResult Index()
    {
        
        var departments = db.Departments.ToList();
        return View(departments);
    }
    
    public ActionResult Detail(int id){
        

        var p1 = db.Departments.Find(id);
        return View(p1);
    }

    public ActionResult Add(){
        return View();
    }

    [HttpPost]
    public ActionResult Add(Department departments){
        db.Departments.Add(departments);
        db.SaveChanges();
        // return Redirect("/employee");
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Update(int id){

        var departments = db.Departments.Find(id);
        return View(departments);
    }

    

    [HttpPost]
    public ActionResult Update(Department departments){
        
        db.Departments.Attach(departments);
        db.Departments.Update(departments);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id){

        var department = db.Departments.Find(id);
        return View(department);
    }

    [HttpPost]
    public ActionResult Delete(Department departments){
        db.Departments.Attach(departments);
        db.Departments.Remove(departments);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }




}


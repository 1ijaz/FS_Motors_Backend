using FS_Motors.Data;
using FS_Motors.Interfaces;
using FS_Motors.Models;

namespace FS_Motors.Repositories
{
    public class CarModelTypeRepository : ICarModelTypeInterface
    {
        //private readonly DataContext _context;

        //public CarModelTypeRepository(DataContext context)
        //{
        //    _context = context;
        //}

        //public async Task<List<CarModelType>> AddCar(CarModelType CarModelType)
        //{
        //    _context.CarModelTypes.Add(CarModelType);
        //    await _context.SaveChangesAsync();
        //    return await _context.Cars.ToListAsync();
        //}

        //public async Task<List<Car>?> DeleteCar(int id)
        //{
        //    var Car = await _context.Cars.FindAsync(id);
        //    if (Car is null)
        //        return null;

        //    _context.Cars.Remove(Car);
        //    await _context.SaveChangesAsync();

        //    return await _context.Cars.ToListAsync();
        //}

        //public async Task<List<Car>> GetAllCars()
        //{
        //    var Cars = await _context.Cars.ToListAsync();
        //    return Cars;
        //}

        //public async Task<Car?> GetSingleCar(int id)
        //{
        //    var Car = await _context.Cars.FindAsync(id);
        //    if (Car is null)
        //        return null;

        //    return Car;
        //}

        //public async Task<List<Car>?> UpdateCar(int id, Car request)
        //{
        //    var Car = await _context.Cars.FindAsync(id);
        //    if (Car is null)
        //        return null;

        //    //Car.Car_Id = request.Car_Id;
        //    //Car.First_Name = request.First_Name;
        //    //Car.Last_Name = request.Last_Name;
        //    //Car.Age = request.Age;
        //    //Car.Email = request.Email;
        //    //Car.Address = request.Address;

        //    await _context.SaveChangesAsync();

        //    return await _context.Cars.ToListAsync();
        //}
    }
}

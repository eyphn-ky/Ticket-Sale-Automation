using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAll(Expression<Func<Movie, bool>> filter = null);
        Movie Get(Expression<Func<Movie, bool>> filter);
        void Add(Movie entity);
        void Update(Movie entity);
        void Delete(Movie entity);
    }
}

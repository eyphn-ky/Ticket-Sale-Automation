using BusinessLogic.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;
        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal; 
        }
        public void Add(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Movie Get(Expression<Func<Movie, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll(Expression<Func<Movie, bool>> filter = null)
        {
            return _movieDal.GetAll();
       }

        public void Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}

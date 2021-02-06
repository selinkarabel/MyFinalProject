using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//Core layer does not reference other layers.. Because core layer is undependent.
namespace Core.DataAccess
{
    //dont forget to make it public

    //generic constraint
    //class:reference type
    //IEntity: it might be IEntity or the object might be which implements IEntity
    //new():it have to be with new()
    public interface IEntityRepository<T> where T:class,IEntity,new() //T means the type of it, product category etc.. We make it generic.
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filter=null means that filter is an option if user doesnt gives filter it returns all data

        T Get(Expression<Func<T, bool>> filter); //eg. getting details. Filter means, the user has to send a filter to use this method.

        // methods of interface are public as default
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}

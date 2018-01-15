using App.Mvc.IRepository.Base;
using App.Mvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;

namespace App.Mvc.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        WMBlogDB db = new WMBlogDB();

        protected DbSet<TEntity> _dbSet;
        public BaseRepository()
        {
            _dbSet = db.Set<TEntity>();
        }
        public void Add(TEntity model)
        {
            _dbSet.Add(model);
        }

        public void Delete(TEntity model, bool isadded)
        {
            if (!isadded)
            {
                _dbSet.Attach(model);
            }
            _dbSet.Remove(model);
        }

        public void Edit(TEntity model)
        {
            db.Entry(model).State = EntityState.Modified;
        }

        public void Edit(TEntity model, string[] propertys)
        {
            if (model == null)
            {
                throw new Exception("实体不能为空");
            }

            if (propertys.Any() == false)
            {
                throw new Exception("要修改的属性至少要有一个");
            }
            //将model追击到EF容器
            DbEntityEntry entry = db.Entry(model);

            entry.State = EntityState.Unchanged;

            foreach (var item in propertys)
            {
                entry.Property(item).IsModified = true;
            }

            //关闭EF对于实体的合法性验证参数
            db.Configuration.ValidateOnSaveEnabled = false;
        }

        public List<TEntity> QueryByPage<TKey>(int pageIndex, int pagesize, out int rowcount, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> keySelector, bool IsQueryOrderBy)
        {
            rowcount = _dbSet.Count(predicate);
            if (IsQueryOrderBy)
            {
                return _dbSet.Where(predicate).OrderBy(keySelector).Skip((pageIndex - 1) * pagesize).Take(pagesize).ToList();
            }
            else
            {
                return _dbSet.Where(predicate).OrderByDescending(keySelector).Skip((pageIndex - 1) * pagesize).Take(pagesize).ToList();
            }
        }

        public List<TEntity> QueryJoin(Expression<Func<TEntity, bool>> predicate, string[] tableNames)
        {
            if (tableNames == null && tableNames.Any() == false)
            {
                throw new Exception("缺少连表名称");
            }

            DbQuery<TEntity> query = _dbSet;

            foreach (var table in tableNames)
            {
                query = query.Include(table);
            }

            return query.Where(predicate).ToList();
        }

        public List<TEntity> QueryOrderBy<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> keySelector, bool IsQueryOrderBy)
        {
            if (IsQueryOrderBy)
            {
                return _dbSet.Where(predicate).OrderBy(keySelector).ToList();
            }
            return _dbSet.Where(predicate).OrderByDescending(keySelector).ToList();
        }

        public List<TEntity> QueryWhere(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public List<TResult> RunProc<TResult>(string sql, params object[] pamrs)
        {
            return db.Database.SqlQuery<TResult>(sql, pamrs).ToList();
        }

        public int SaverChanges()
        {
            return db.SaveChanges();
        }
    }
}

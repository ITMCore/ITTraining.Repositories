using System;
using System.Collections.Generic;
using ITTraining.Infrastructure;
using ITTrainingDBContext.DBContext;
using System.Linq;

namespace ITTraining.Repositories.Admin
{
	public class SubjectRepository : ISubjectRepository
	{
		private ITTrainingRepoDbContext _dbContext;

		public SubjectRepository()
		{
			_dbContext = new ITTrainingRepoDbContext();
		}

		public void Add(Subjects resource)
		{
			_dbContext.Subjects.Add(resource);
		}

		public IEnumerable<Subjects> FindAll(Func<Subjects, bool> match)
		{
			return _dbContext.Subjects.Where(match);
		}

		public IEnumerable<Subjects> FindAllSubjectByName(string subjeName)
		{
			return _dbContext.Subjects.Where(x => x.SubjectName.Equals(subjeName));
		}

		public IEnumerable<Subjects> FindAllSubjectsForKeyword(string keywordPattern)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Subjects> FindById(object resourceIdenitifer)
		{
			throw new NotImplementedException();
		}

		public void Remove(Subjects resource)
		{
			throw new NotImplementedException();
		}

		public void Save(Subjects resource)
		{
			throw new NotImplementedException();
		}
	}
}

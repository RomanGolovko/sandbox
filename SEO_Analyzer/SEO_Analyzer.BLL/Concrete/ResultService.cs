using System.Collections.Generic;
using AutoMapper;
using SEO_Analyzer.BLL.Abcstract;
using SEO_Analyzer.BLL.DTO;
using SEO_Analyzer.Cross_Cutting.Security;
using SEO_Analyzer.DAL.Abstract;
using SEO_Analyzer.DAL.Entities;

namespace SEO_Analyzer.BLL.Concrete
{
    public class ResultService : IResultService
    {
        IUnitOfWork db { get; set; }
        public ResultService(IUnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<ResultDTO> GetResults()
        {
            // using automapper for the projection of one collection to another / 
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<Result, ResultDTO>();
            return Mapper.Map<IEnumerable<Result>, List<ResultDTO>>(db.Results.GetAll());
        }

        public ResultDTO GetResult(int? id)
        {
            // validation / валидация
            if (id == null)
            {
                throw new ValidationException("Result id not set!", "");
            }

            var result = db.Results.Get(id.Value);

            // validation / валидация
            if (result == null)
            {
                throw new ValidationException("Result not found!", "");
            }

            // add words to result / добавляем words к result
            var words = db.Words.GetAll();
            foreach (var word in words)
            {
                if (word.ResultId == result.Id)
                {
                    result.Words.Add(word);
                }
            }

            // using automapper for the projection of one collection to another / 
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<Word, WordDTO>();

            ResultDTO resultDTO = new ResultDTO();
            resultDTO.Id = result.Id;
            resultDTO.Link_Text = result.Link_Text;
            resultDTO.Words = Mapper.Map<IEnumerable<Word>, List<WordDTO>>(result.Words);

            return resultDTO;
        }

        public void AddResult(ResultDTO resultDTO)
        {
            // using automapper for the projection of one collection to another / 
            // применяем автомаппер для проекции одной коллекции на другую
            Mapper.CreateMap<WordDTO, Word>();

            Result result = new Result();
            result.Id = resultDTO.Id;
            result.Link_Text = resultDTO.Link_Text;
            result.Words = Mapper.Map<IEnumerable<WordDTO>, List<Word>>(resultDTO.Words);
            db.Results.Create(result);
        }
    }
}

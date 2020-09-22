using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProvaBimestral.Models;

namespace ProvaBimestral.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EleicaoController : ControllerBase
    {
        private static List<Eleicao> _lstEleicoes { get; set; } = new List<Eleicao>();

        [HttpGet]
        public IEnumerable<Eleicao> Get()
        {
            return _lstEleicoes;
        }

        [HttpGet("{id}")]
        public Eleicao Get(int id)
        {
            return _lstEleicoes.FirstOrDefault(a => a.Id == id);
        }

        [HttpPost]
        public Eleicao Post(Eleicao objEleicao)
        {
            if (_lstEleicoes.Count > 0)
                objEleicao.Id = _lstEleicoes.Max(a => a.Id) + 1;
            else
                objEleicao.Id = 1;

            _lstEleicoes.Add(objEleicao);

            return objEleicao;
        }
    }
}

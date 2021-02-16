using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicador
{
	class Class1
	{
		private string nome, apelido, classe, disciplina, escola, data;
		public Class1(string nome, string apelido, string classe, string disciplina, string escola, string data)
		{
			this.nome = nome;
			this.apelido = apelido;
			this.classe= classe;
			this.disciplina= disciplina;
			this.escola= escola;
			this.data= data;
		}
		public string getClasse() { return classe; }
		public string getNome() { return nome; }
		public string getDisciplina() { return disciplina; }
		public string getEscola() { return escola; }
		public string getData() { return data; }
	}
}

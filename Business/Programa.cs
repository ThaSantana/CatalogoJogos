using System;
using System.Collections.Generic;

namespace Business
{
    public class Programa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
       

        public List<Programa> Lista()
        {
            var lista = new List<Programa>();
            var jogoDb = new Database.Programa();
            foreach (DataRow row in jogoDb.Lista().Rows)
            {
                var jogo = new Programa();
                jogo.Id = Convert.ToInt32(row["id"]);
                jogo.Nome = row["nome"].ToString();
                jogo.Genero = row["conteudo"].ToString();
                

                lista.Add(jogo);
            }
            return lista;
        }
        public void Save()
        {
            new Database.Programa().Salvar(this.Id, this.Nome, this.Genero);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

using DPXamarin.Model;

namespace DPXamarin.BaseDb
{
    public class AcessoDados : IDisposable
    {
        private SQLite.Net.SQLiteConnection _conexao;

        public AcessoDados()
        {
            var config = DependencyService.Get<IConfig>();
            _conexao = new SQLite.Net.SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.DiretorioDB, "bancodados.db3"));

            _conexao.CreateTable<Comic>();
        }

        public void Insert(Comic comic)
        {
            _conexao.Insert(comic);
        }

        public void Delete(Comic comic)
        {
            _conexao.Delete(comic);
        }

        public Comic ObterPorId(int id)
        {
            return _conexao.Table<Comic>().FirstOrDefault(c => c.id == id);
        }

        public void Update(Comic comic)
        {
            _conexao.Update(comic);
        }

        public List<Comic> Listar()
        {
            return _conexao.Table<Comic>().OrderBy(c => c.title).ToList();
        }

        public void Dispose()
        {
            _conexao.Dispose();
        }
    }
}

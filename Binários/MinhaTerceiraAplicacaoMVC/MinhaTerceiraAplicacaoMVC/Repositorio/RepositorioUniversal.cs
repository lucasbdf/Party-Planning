using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Newtonsoft.Json;
using System.IO;

namespace MinhaTerceiraAplicacaoMVC.Repositorio
{
    public static class RepositorioUniversal<T> where T: class 
    {

        
        public static void GraveObjeto(T obj){
            var lista = RecupereLista();

            lista.Add(obj);

            GraveListaDeObjetos(lista);
        }
        
        
        public static void GraveListaDeObjetos(List<T> listaDeObjetos) {

            var listaConvertidaJson = JsonConvert.SerializeObject(listaDeObjetos);
            CrieArquivoDoTipo(listaConvertidaJson);
        }


        public static List<T> RecupereLista() {

            var pathCompleto = ObtenhaPathCompleto();
            var listaDeObjetos = new List<T>();

            if (ExisteArquivo(pathCompleto)) {

                using (var strReader = new StreamReader(pathCompleto)) {

                    var conteudo = strReader.ReadLine();
                    var listaDoArquivo = JsonConvert.DeserializeObject<List<T>>(conteudo);

                    listaDeObjetos.AddRange(listaDoArquivo);
                }
            }

            return listaDeObjetos;
        
        }
        //private static void CrieArquivoDoObjeto(List<T> listaDeObjetos) {

        //    var listaConvertidaJson = JsonConvert.SerializeObject(listaDeObjetos);
                    
        //}

        private static void CrieArquivoDoTipo(string conteudo)
        {
            var nomePathCompleto = ObtenhaPathCompleto();

            ExcluaArquivoSeExistir();

            using (var strWriter = new StreamWriter(ObtenhaPathCompleto())) {
                strWriter.WriteLine(conteudo);
            }
        }

        private static string ObtenhaPathCompleto() {

            var nomeArquivo = typeof(T).Name;
            var nomePathCompleto = string.Format("{0}{1}", "C:\\", nomeArquivo);

            return nomePathCompleto;

        }

        private static bool ExisteArquivo(string nomePathCompleto) {

            return File.Exists(nomePathCompleto);
        }
         
        private static void ExcluaArquivoSeExistir(){

            var nomePathCompleto = ObtenhaPathCompleto();

            if (ExisteArquivo(nomePathCompleto)) {
                File.Delete(nomePathCompleto);
            }
        }





        }
    }

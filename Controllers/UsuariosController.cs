using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RpgMvc.Models;
using Microsoft.AspNetCore.Http;

namespace RpgMvc.Controllers
{
    public class UsuariosController : Controller
    {
        public string uriBase = "http://CarlosKauan.somee.com/RpgApi/Usuarios/";
        //xyz será substituido pelo nome do seu site na API
        
        [HttpGet]
        public ActionResult Index(){
            //Retornar rota.
            return View("CadastrarUsuario");
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(UsuarioViewModel u){
            
            try
            {
                //Toda a configuração do metodo
                HttpClient httpClient = new HttpClient();
                string uriComplementar = "Registrar";
                //Acionar Json
                var content = new StringContent(JsonConvert.SerializeObject(u));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("Application/json");
                HttpResponseMessage response = 
                    await httpClient.PostAsync(uriBase + uriComplementar, content);
                
                string serialized = await response.Content.ReadAsStringAsync();

                //Condição
                if (response.StatusCode == System.Net.HttpStatusCode.OK){
                    TempData["Mensagem"] = 
                        string.Format("Úsuario {0} registrado com sucesso! Faça o Login para acessar.", u.Username);
                    
                    return View("AutenticarUsuario");
                }
                else{
                    TempData["MessagemErro"] = serialized;
                    return RedirectToAction("Index");
                }
            }
            catch (System.Exception ex)
            {
                //Configuração do erro
                TempData["MessagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
            
        }
        
        [HttpGet]   
        public ActionResult IndexLogin(){

            return View("AutenticarUsuario");

        }

        [HttpPost]
        public async Task<ActionResult> AutenticarAsync(UsuarioViewModel u){
            HttpClient httpClient = new HttpClient();
            string uriComplementar = "Autenticar";

            var content = new StringContent(JsonConvert.SerializeObject(u));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("Application/json");
            HttpResponseMessage response = 
                await httpClient.PostAsync(uriBase + uriComplementar, content);

            string serialized = await response.Content.ReadAsStringAsync();

               //Condição
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    HttpContext.Session.SetString("SessionTokenUsuario", serialized);
                    TempData["Mensagem"] = string.Format("Bem Vindo {0} !!!", u.Username);
                    return RedirectToAction("Index", "Personagens");

                }
                else
                {
                    TempData["MessagemErro"] = serialized;
                    return IndexLogin();
                }


        }
    }




}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class PersonagemExercicioController : ControllerBase
    {
        //Criação de uma lista já adicionando os objetos dentro.
        private static List<Personagem> personagens = new List<Personagem>() {
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro}, 
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        //Métodos deverão ser construídos a partir daqui.    
        //a)
        [HttpGet("GetByClasse/{classeId}")]
        public IActionResult GetByClasse(int classeId)
        {
            List<Personagem> listaFinal =  personagens.FindAll(p => p.Classe == (ClasseEnum)classeId);

            if(listaFinal.Count == 0)
                return NotFound("Nenhum personagem encontrado.");

            return Ok(listaFinal);
        }

        //b)
        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetbyNome(string nome)
        {
            Personagem p = personagens.Find(p => p.Nome == nome);

            if(p == null)            
                return NotFound("nenhum personagem com este nome foi encontrado.");
            
            return Ok(p);

            /*List<Personagem> listaFinal = personagens.FindAll(p => p.Nome == nome);

            if(listaFinal.Count == 0)                        
                return NotFound("nenhum personagem com este nome foi encontrado.");
            

            return Ok(listaFinal);*/
        }

        //c)
        [HttpPost("PostValidacao")]
        public IActionResult PostValidacao(Personagem novoPersonagem)
        {
            if(novoPersonagem.Defesa < 10 || novoPersonagem.Inteligencia > 35)
                return BadRequest("Personagens devem ter defesa a partir de 10 e inteligência maior que 30");

            personagens.Add(novoPersonagem);
            
            return Ok(personagens);
        }


        //d)
        [HttpPost("PostValidacaoMago")]
        public IActionResult PostValidacaoMago(Personagem novoPersonagem)
        {
            if(novoPersonagem.Classe == ClasseEnum.Mago && novoPersonagem.Inteligencia < 35)
                return BadRequest("Personagens do tipo Mago não podem ter inteligência menor que 35.");

            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }

        //e)
        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigoMago()
        {
            List<Personagem> listaSemCavaleiro = 
                personagens.FindAll(p => p.Classe != ClasseEnum.Cavaleiro)
                    .OrderByDescending(ord => ord.PontosVida) //OrderByDescending using System.Linq                   
                    .ToList();

            return Ok(listaSemCavaleiro);
        }

        //f)
        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {
            int quantidade = personagens.Count;
            int somaInteligencia = personagens.Sum(p => p.Inteligencia);

            //Outra maneira (1)
            string msg = 
                string.Format("A lista contém {0} personagens e o somatório da inteligência é {1}", quantidade, somaInteligencia);            
            return Ok(msg);

            //Outra maneira (2)
            //return Ok($"A lista contém {quantidade} personagens e somatório da inteligência é {somaInteligencia}");

            //Maneira simples (3)            
            /*return Ok("A lista contém " + quantidade + " personagens e somatório da inteligência é " + somaInteligencia);*/
        }

        
    }
}



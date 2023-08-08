import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FormularioService } from './formulario.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioComponent {

  constructor(
    private router:Router,
    private service: FormularioService  
  ) {}

  cadastro = {
    nome: '',
    cpf: '', 
    telefone: '', 
    rua: '',
    numero: '',
    bairro: '',
    cidade: '',
    codigo: ''
  }

  AdicionarCadastro(){
    this.cadastro.codigo = this.cadastro.cpf.substring(0,4) 
    this.service.criar(this.cadastro).subscribe(() => {
      this.router.navigate(['/login'])
      //mudar acima para ser direcionado para pagina de listagem
    })
  }

  Cancelar(){
    this.router.navigate(['/login'])
  }
}

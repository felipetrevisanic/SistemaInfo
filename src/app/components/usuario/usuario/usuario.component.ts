import { Component, Input } from '@angular/core';


@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent  {
  @Input() usuario = {
    nome: '',
    cpf: '', 
    telefone: '', 
    rua: '',
    numero: '',
    bairro: '',
    cidade: '',
    codigo: ''
  }
}

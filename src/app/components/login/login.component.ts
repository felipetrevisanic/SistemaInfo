import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Login } from './login';
import { LoginService } from './login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  constructor(
    private router:Router,
    private http: HttpClient,
    private service: LoginService
    ) {}
  
    private readonly API = 'https://localhost:7007/api/Admin'
 
  opcao = true

  adminLista:Login = {
    login: '',
    senha: ''
  };
   
  usuario = {
    login: '',
    senha: ''
  }

  abrirAviso(){
    this.opcao ? this.opcao = false : this.opcao = true
  }

  ngOnInit(): void {
  }

  validarLogin() {
    this.service.validar().subscribe(
      userData => {
        this.usuario.login = this.usuario.login.toUpperCase()
        if (userData.login === this.usuario.login && userData.senha === this.usuario.senha) {
          this.router.navigate(['/home'])
        } else {
          console.log(userData)
          alert('Usuario e/ou senha incorretos')
        }
      },
      error => {
        console.error('Erro ao obter dados do usuário: ', error);
      }
    );
  }
}
    
  


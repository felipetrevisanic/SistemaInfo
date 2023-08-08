import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Usuario } from './formulario'

@Injectable({
  providedIn: 'root'
})
export class FormularioService {

  private readonly API = 'https://localhost:7007/api/Usuario'
  constructor(private http: HttpClient) { }

  listar(): Observable<Usuario[]> {
    return this.http.get<Usuario[]>(this.API)
  }

  criar(usuario: Usuario): Observable<Usuario> {
    return this.http.post<Usuario>(this.API, usuario)
  }

  editar(usuario:Usuario): Observable<Usuario> {
    const url = `${this.API}/${usuario.id}`
    return this.http.put<Usuario>(url, usuario)
  }

  excluir(id: Number): Observable<Usuario> {
    const url = `${this.API}/${id}`
    return this.http.delete<Usuario>(url)
  }
 
  buscarPorId(id: Number): Observable<Usuario> {
    const url = `${this.API}/${id}`
    return this.http.get<Usuario>(url) 
  }
}

import { Component, Input } from '@angular/core';
import { FormularioService } from '../../formulario/formulario.service';
import { Usuario } from '../../formulario/formulario';
import { faHourglass } from '@fortawesome/free-solid-svg-icons'

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css']
})
export class ListaComponent {
  constructor(private service: FormularioService){}

  faHourglass = faHourglass

  listaUsuarios :Usuario[] = [];

  @Input() usuario = {
    id: 0,
    nome: 'i love angular',
  }

  ngOnInit(): void {
    this.service.listar().subscribe((listaUsuarios) => {
      this.listaUsuarios = listaUsuarios
    })
  }
}

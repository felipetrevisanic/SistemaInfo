import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { faBars, faX } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-cabecalho',
  templateUrl: './cabecalho.component.html',
  styleUrls: ['./cabecalho.component.css']
})
export class CabecalhoComponent {

  constructor(private router: Router) {}

  isSidebarOpen = false;
  toggleSidebar(){    this.isSidebarOpen = !this.isSidebarOpen  }

  faBars=faBars
  faX=faX

  isLoginRoute(): boolean {
    return this.router.url === '/login';
  }
}

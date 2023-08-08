import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormularioComponent } from './components/formulario/formulario.component';
import { CabecalhoComponent } from './components/cabecalho/cabecalho.component';
import { RodapeComponent } from './components/rodape/rodape.component';
import { LoginComponent } from './components/login/login.component';
import { FormsModule } from '@angular/forms';
import { NgxMaskPipe, NgxMaskDirective, provideNgxMask } from 'ngx-mask';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './components/home/home.component';
import { ListaComponent } from './components/usuario/lista/lista.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { UsuarioComponent } from './components/usuario/usuario/usuario.component';

@NgModule({
  declarations: [
    AppComponent,
    FormularioComponent,
    CabecalhoComponent,
    RodapeComponent,
    LoginComponent,
    HomeComponent,
    ListaComponent,
    UsuarioComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    NgxMaskDirective, 
    NgxMaskPipe,
    HttpClientModule,
    FontAwesomeModule

  ],
  providers: [provideNgxMask()],
  bootstrap: [AppComponent]
})
export class AppModule { }

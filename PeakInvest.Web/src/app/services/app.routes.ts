import { Routes } from '@angular/router';
import { CadastroComponent } from '../components/cadastro/cadastro.component';
import { ConsultaComponent } from '../components/consulta/consulta.component';

export const routes: Routes = [
  { path: '', redirectTo: '/cadastro', pathMatch: 'full' },
  { path: 'cadastro', component: CadastroComponent },
  { path: 'consulta', component: ConsultaComponent }
];

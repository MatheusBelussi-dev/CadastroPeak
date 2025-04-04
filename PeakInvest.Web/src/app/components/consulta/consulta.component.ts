import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

interface ConsultaResponse {
  nome: string;
}

@Component({
  selector: 'app-consulta',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './consulta.component.html',
  styleUrls: ['./consulta.component.scss']
})
export class ConsultaComponent {
  id: number = 0;
  nome: string = '';
  idsPermitidos = [1, 2, 3];

  constructor(private http: HttpClient) {}

  buscar() {
    if (!this.idsPermitidos.includes(this.id)) {
      alert('Por favor, insira apenas os IDs 1, 2 ou 3');
      this.nome = '';
      return;
    }

    this.http.get<ConsultaResponse>(`https://localhost:7052/api/Consulta/${this.id}`)
      .subscribe({
        next: (response) => {
          this.nome = response.nome;
        },
        error: (error) => {
          console.error('Erro ao buscar nome:', error);
          alert('Erro ao buscar nome. Verifique se o ID existe.');
          this.nome = '';
        }
      });
  }
} 
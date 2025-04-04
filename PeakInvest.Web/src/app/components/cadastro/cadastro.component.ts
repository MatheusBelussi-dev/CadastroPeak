import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

interface CalculoResponse {
  quantidadeParcelas: number;
  valorParcela: number;
  resultadoCalculo: number;
}

@Component({
  selector: 'app-cadastro',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent {
  formData = {
    quantidadeParcelas: 0,
    valorParcela: 0
  };
  resultado: number | null = null;

  constructor(private http: HttpClient) {}

  onSubmit() {
    this.http.post<CalculoResponse>('https://localhost:7052/api/Calculo', this.formData)
      .subscribe({
        next: (response) => {
          this.resultado = response.resultadoCalculo;
        },
        error: (error) => {
          console.error('Erro ao calcular:', error);
          alert('Erro ao calcular. Por favor, tente novamente.');
        }
      });
  }
} 
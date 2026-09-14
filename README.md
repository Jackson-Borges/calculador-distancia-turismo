# 🌍 Marcador de Viagem

Um aplicativo de console simples desenvolvido em **C#** que simula a escolha de destinos turísticos e calcula o tempo estimado de espera com base no meio de transporte selecionado.

---

## 🚀 Funcionalidades

* **Lista de Destinos:** Apresenta opções de viagens como Ubatuba-SP, Floripa-SC e Foz do Iguaçu-PR.
* **Cálculo de Tempo:** Informa o tempo de espera do transporte escolhido (Avião, Ônibus ou Táxi).
* **Fluxo Contínuo:** Permite ao usuário realizar novos cálculos ou encerrar a sessão de forma interativa.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET)
* **Paradigma:** Programação Estruturada / Console Application

---

## 💻 Demonstração

### 1. Seleção de Opções e Resultado
O usuário seleciona o destino e o transporte desejado para obter o tempo estimado:

<img width="1477" height="461" alt="Captura de tela 2026-09-13 123751" src="https://github.com/user-attachments/assets/77a8da78-8bad-4cd4-bbdf-af8399402a2d" />


### 2. Encerramento da Sessão
Ao optar por não calcular outro transporte, o sistema finaliza o atendimento:

<img width="1481" height="452" alt="Captura de tela 2026-09-13 123935" src="https://github.com/user-attachments/assets/74ec945c-acd9-4571-b994-c417cc5670c3" />


---

## 📋 Como Executar o Projeto

1. Certifique-se de ter o **SDK do .NET Core / .NET Preview** instalado em sua máquina.
2. Clone este repositório:
   ```bash
   git clone https://github.com/Jackson-Borges
   ```
3. Navegue até a pasta do projeto:
   ```bash
   cd "Marcador de Viagem"
   ```
4. Execute o programa:
   ```bash
   dotnet run
   ```

---

## 💡 Estrutura de Código Destacada

O projeto utiliza uma estrutura condicional `switch-case` para definir o tempo de viagem com base no caractere inserido pelo usuário, além de uma estrutura de repetição controlada por `goto` para reiniciar o menu principal caso o usuário queira realizar uma nova consulta.


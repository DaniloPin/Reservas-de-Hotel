Desenvolvi um sistema para um hotel que deseja organizar suas reservas. Ao realizar uma reserva, é necessário associar um hóspede a um quarto, registrar a quantidade de diárias e calcular automaticamente o valor total da estadia. Mas, é importante garantir que:

- A quantidade de diárias seja obrigatoriamente maior que zero;
- O valor da diária do quarto não seja negativo nem nulo;
- O sistema não permita alterações manuais no valor total da reserva.

Garanti essas regras usando encapsulamento adequado, protegendo os dados e centralizando a lógica de verificação e cálculo dentro das próprias classes.

Criei:

Classe Hospede:
 - Propriedade pública Nome, definida no construtor

Classe Quarto:
   - Propriedade pública Numero
   - Propriedade ValorDiaria, com get e set, validando que o valor seja positivo

Classe Reserva:
  - Campo privado diarias
  - Propriedade somente leitura Hospede (objeto)
  - Propriedade somente leitura Quarto (objeto)
  - Propriedade somente leitura ValorTotal (calculada)
  - Construtor que receba Hospede, Quarto e diarias, e valide se as diárias são maiores que zero

    ![image](https://github.com/user-attachments/assets/8e1802c8-c10d-44f7-ab64-52b5d4c28b4e)


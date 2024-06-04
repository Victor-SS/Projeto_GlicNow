# Projeto_GlicNow
## Principais Recursos!

- Criação de usuário: Permite que os usuários criem uma conta para acessar todas as suas funcionalidades.
    
    Os usuários podem criar uma conta no Glic fornecendo informações básicas, como nome de usuário, senha e informações de contato.
    
- Armazenamento de glicemia: Permite que os usuários registrem e monitorem seus níveis de glicose ao longo do tempo.
    
    Os usuários podem registrar seus níveis de glicose ao longo do tempo, fornecendo informações como data, hora e valor da glicemia.
    
- Criação de mapa de glicemia: Oferece uma visualização gráfica dos dados de glicemia dos usuários para identificar tendências e padrões.
    
    Os dados de glicemia dos usuários são visualizados em um mapa gráfico para identificar padrões e tendências ao longo do tempo.
    
- Calendário de consultas médicas: Permite que os usuários agendem e acompanhem suas consultas médicas relacionadas ao diabetes.
    
    Os usuários podem agendar consultas médicas relacionadas ao diabetes e receber lembretes sobre compromissos futuros.
    
- Registro de hábitos: Permite que os usuários registrem hábitos relacionados à saúde, como dieta, exercícios e medicação.
    
    Os usuários podem registrar hábitos relacionados à saúde, como dieta, exercícios e medicação, para acompanhar seu impacto nos níveis de glicemia.
    
- Analise de Glicemia: Oferece uma visualização de seu controle glicêmico, utilizando filtros e busca.
    
    Os dados de glicemia dos usuários são visualizados em gráficos para identificação de alterações em suas glicemias.    

## Banco de Dados!

- Tabela de Usuários.
    
    Login Varchar 25;
    
    Senha Varchar 255;
    
    E-mail Varchar 100;
    
    Nome Completo Varchar 100;
    
    CPF Varchar 14;
    
    Data de Nascimento Date;
    
    Foto Perfil img;
    
    - Sexo Domínio Varchar 9;
        1. Masculino.
        2. Feminino.
        3. Prefiro não dizer.
           
    - Tipo de Diabetes Domínio Varchar 20;
        1. Pré-diabetes.
        2. Diabetes tipo 1
        3. Diabetes tipo 2
        4. Diabetes Gestacional.
           
- Tabela de Registros de Glicemia.
    
    Usuário Id Foreign key;
    
    Valor da Glicemia int;
    
    Data e hora date time;
    
    Basal bolear;
    
    Valor da Insulina int;
    
    Valor do Carboidrato opcional Int;
    
- Tabela de Consultas Médicas.
    
    Usuário Id Foreign key;
    
    Descrição varchar 100;
    
    Nome do Medico varchar 100;
    
    Data e Hora date time;
    
    Nota Adicional Opcional varchar 1000;
    
- Tabela de Registros de Hábitos.
    
    Usuário Id Foreign Key;
    
    - Tipo de Hábito Domínio varchar 25;
        1. Dieta.
        2. Exercício.
        3. Medicação.
        4. Boas Práticas.
        5. Jejum.
    
    Descrição varchar 100;
    
    Data e Hora date time;
    
- Tabela de Analise de Glicemia.
    
    Usuário Id Foreign Key;
    
    Faixa Normal int;
    
    Faixa de Hipo int;
    
    Faixa Alta int;
    
    Faixa de Hiper int;

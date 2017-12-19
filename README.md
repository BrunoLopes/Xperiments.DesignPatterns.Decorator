##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Decorator 

> Decorator ou wrapper, é um padrão de projeto de software que permite adicionar um comportamento a um objeto já existente em tempo de execução, ou seja, agrega dinamicamente responsabilidades adicionais a um objeto.[1] Decorators oferecem uma alternativa flexível ao uso de herança para estender uma funcionalidade, com isso adiciona-se uma responsabilidade ao objeto e não à classe.

### Motivação

> O Decorator surgiu da necessidade de adicionar um comportamento, funcionalidade ou estado extra a um objeto em tempo de execução, por exemplo quando Herança não é concebível por ser um caso que geraria um número muito alto de sub-classes.

> Suponha que existe um objeto Arma, ela pode ter comportamentos diferentes dependendo da munição, dependendo do tipo de mira que tiver, se tiver algum tipo de silenciador ou outro acessório. Imagine criar agora uma sub classe para cada combinação possível de armas, o número de classes aumenta exponencialmente para cada opção a mais que você tiver. É ai que entra o Decorator.

> Outro exemplo de utilização desse padrão seria, por exemplo, um sistema de reserva de passagens no qual o passageiro possa adicionar itens e serviços à sua passagem área ou viária. Como bagagens extras, cabine com espaço maior e opções de refeição. Uma árvore de natal que recebe a adição de objetos e luzes que a decoram também é um outro exemplo do mundo real no qual aplicar-se-ia o padrão Decorator.

> São diversos os exemplos nos sistemas que usamos no dia-a-dia, cuja função é adicionar responsabilidades e comportamentos à um objeto dinamicamente e que sem esse padrão, a capacidade de personalizar e editar classes tornaria-se inviável.

### Aplicabilidade
* Acrescentar ou remover responsabilidades a objetos individuais dinamicamente, de forma transparente
* Evitar a explosão de subclasses para prover todas as combinações de responsabilidades
* Acrescentar responsabilidades a um objeto dinamicamente
* Prover alternativa flexível ao uso de subclasses para se estender a funcionalidade de uma classe
* Pode-se utilizar Decorator quando a herança seria uma boa alternativa mas a definição da classe está escondida ou não disponível para herança
* pode usar um ou mais decoradores para englobar um objeto
* Os padrões Decorador e Composite podem ser visto como similares, uma vez que ambos usam o princípio de recursividade. O decorator pode ser visto como uma versão simplificada do padrão Composite, porém o Decorator apenas adiciona responsabilidades adicionais e não é usado para agregar objetos

### Estrutura
> ![N|MFYIT](https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Decorator_.tif/lossless-page1-251px-Decorator_.tif.png)

---

## Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using `https://github.com/BrunoLopes/Xperiments.DesignPatterns.Interpreter`

### Setup



> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT © 2017  

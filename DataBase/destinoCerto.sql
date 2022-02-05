CREATE DATABASE `destinoCerto`;

CREATE TABLE `Usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `nome` varchar(255) NOT NULL,
  `login` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL,
  `dataNascimento` date NOT NULL
);

CREATE TABLE `PacotesTuristicos` (
  `id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `nome` varchar(255) NOT NULL,
  `origem` varchar(255) NOT NULL,
  `destino` varchar(255) NOT NULL,
  `atrativos` varchar(255),
  `saida` date NOT NULL,
  `retorno` date NOT NULL,
  `usuario` int(11),
   CONSTRAINT `fk_usuario` FOREIGN KEY(`usuario`) REFERENCES `Usuario`(`id`)
);

INSERT INTO `Usuario` (`nome`, `login`, `senha`, `dataNascimento`) VALUES
('Admin', 'admin', 'admin', '2022-01-01');




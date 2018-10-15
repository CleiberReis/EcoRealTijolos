CREATE TABLE `tbl_cliente` (
  `cli_id` int(11) NOT NULL AUTO_INCREMENT,
  `cli_nome` varchar(45) NOT NULL,
  `cli_cpf` varchar(14) NOT NULL,
  `cli_telefone` varchar(13) NOT NULL,
  `cli_email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`cli_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

CREATE TABLE `tbl_fornecedor` (
  `for_id` int(11) NOT NULL,
  `for_nome` varchar(45) NOT NULL,
  `telefone` varchar(13) NOT NULL,
  `email` varchar(55) DEFAULT NULL,
  PRIMARY KEY (`for_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `tbl_funcionario` (
  `fun_id` int(11) NOT NULL AUTO_INCREMENT,
  `fun_nome` varchar(45) NOT NULL,
  `fun_cpf` varchar(14) NOT NULL,
  `fun_telefone` varchar(13) NOT NULL,
  `fun_dtNasc` date NOT NULL,
  `fun_endereco` varchar(100) NOT NULL,
  `fun_email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`fun_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `tbl_materia` (
  `mat_id` int(11) NOT NULL AUTO_INCREMENT,
  `mat_nome` varchar(45) NOT NULL,
  `mat_quantidade` int(11) NOT NULL,
  PRIMARY KEY (`mat_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

CREATE TABLE `tbl_perdamateria` (
  `per_id` int(11) NOT NULL AUTO_INCREMENT,
  `per_quantidade` int(11) NOT NULL,
  `per_observacao` varchar(255) NOT NULL,
  `mat_idperda` int(11) NOT NULL,
  PRIMARY KEY (`per_id`),
  KEY `fk_perdamateria1_idx` (`mat_idperda`),
  CONSTRAINT `fk_perdamateria1` FOREIGN KEY (`mat_idperda`) REFERENCES `tbl_materia` (`mat_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `tbl_produto` (
  `prod_id` int(11) NOT NULL AUTO_INCREMENT,
  `prod_nome` varchar(45) NOT NULL,
  `prod_quantTotal` int(11) NOT NULL,
  `prod_valorUnitario` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`prod_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `tbl_pedido` (
  `ped_id` int(11) NOT NULL,
  `ped_data` datetime NOT NULL,
  `ped_idCliente` int(11) NOT NULL,
  `ped_idProduto` int(11) NOT NULL,
  `ped_endereco` varchar(100) NOT NULL,
  `ped_obs` text,
  PRIMARY KEY (`ped_id`),
  KEY `tbl_pedido_ibfk_1` (`ped_idCliente`),
  KEY `tbl_pedido_ibfk_2` (`ped_idProduto`),
  CONSTRAINT `tbl_pedido_ibfk_1` FOREIGN KEY (`ped_idCliente`) REFERENCES `tbl_cliente` (`cli_id`),
  CONSTRAINT `tbl_pedido_ibfk_2` FOREIGN KEY (`ped_idProduto`) REFERENCES `tbl_produto` (`prod_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `tbl_pedidoproduto` (
  `pedpro_id` int(11) NOT NULL AUTO_INCREMENT,
  `ped_id` int(11) NOT NULL,
  `prod_id` int(11) NOT NULL,
  `pedpro_quantidade` int(11) NOT NULL,
  `pedprod_subtotal` decimal(6,2) NOT NULL,
  PRIMARY KEY (`pedpro_id`),
  KEY `tbl_pedido_ibfk_1` (`pedpro_id`),
  KEY `ped_id` (`ped_id`),
  KEY `prod_id` (`prod_id`),
  CONSTRAINT `ped_id` FOREIGN KEY (`ped_id`) REFERENCES `tbl_pedido` (`ped_id`),
  CONSTRAINT `prod_id` FOREIGN KEY (`prod_id`) REFERENCES `tbl_produto` (`prod_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
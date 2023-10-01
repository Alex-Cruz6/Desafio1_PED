-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 01-10-2023 a las 01:25:20
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `desafio1`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente`
--

DROP TABLE IF EXISTS `paciente`;
CREATE TABLE IF NOT EXISTS `paciente` (
  `id_paciente` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `apellido` varchar(50) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `genero` varchar(10) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `presion` varchar(15) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `tipo_sangre` char(3) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  PRIMARY KEY (`id_paciente`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `paciente`
--

INSERT INTO `paciente` (`id_paciente`, `nombre`, `apellido`, `genero`, `presion`, `tipo_sangre`) VALUES
(1, 'Alexander', 'Cruz', 'Masculino', 'Media', 'O+'),
(2, 'Ezequiel', 'Cruz', 'Masculino', 'Baja', 'A+'),
(3, 'Bernabe', 'Anaya', 'Masculino', 'Media', 'AB+'),
(4, 'Elizabeth', 'Calderon', 'Femenino', 'Baja', 'B+'),
(5, 'Isabel', 'Dueñas', 'Femenino', 'Alta', 'AB-'),
(6, 'Josefa', 'Lopez', 'Femenino', 'Media', 'B-'),
(7, 'Cristian', 'Anaya', 'Masculino', 'Alta', 'B+'),
(8, 'Gabriela', 'Gomez', 'Femenino', 'Baja', 'A+'),
(9, 'Fatima', 'Vanegas', 'Femenino', 'Media', 'O+');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `pass` varchar(100) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `usuario`, `pass`) VALUES
(4, 'Celia', '1234'),
(3, 'Alex', '1234'),
(5, 'Ezequiel', '1234'),
(6, 'Gaby', '1234'),
(7, 'David', '1234'),
(8, 'Bernabe', '1234');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

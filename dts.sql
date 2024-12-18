-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-12-2024 a las 06:16:52
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyectof`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dts`
--

CREATE TABLE `dts` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Cuenta` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  `Monto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `dts`
--

INSERT INTO `dts` (`Id`, `Nombre`, `Cuenta`, `Contraseña`, `Monto`) VALUES
(123456, 'Invitado', 'guest@gmail.com', 'invitacion', 60500),
(381985, 'AngelDaniel', 'angelgarcia@gmail.com', 'ANGEL230', 12500),
(387996, 'ObedJosue', 'obedhuerta@gmail.com', 'fanAzul', 10900),
(541664, 'LuisAngel', 'luisAdmin@gmail.com', 'AdminUAA', 30800);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `dts`
--
ALTER TABLE `dts`
  ADD PRIMARY KEY (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

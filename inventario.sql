-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-12-2024 a las 18:00:58
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
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE `inventario` (
  `id` int(11) NOT NULL,
  `imagen` varchar(50) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `precio` int(11) NOT NULL,
  `existencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`id`, `imagen`, `descripcion`, `precio`, `existencia`) VALUES
(17, 'traje1.jpg', 'Traje Negro', 3500, 20),
(20, 'traje2.jpg', 'Traje Gris ', 3300, 20),
(22, 'traje3.jpg', 'Traje Azul', 2200, 20),
(23, 'pantalon.jpg', 'Pantalon Negro', 1200, 20),
(65, 'zapatos.jpg', 'Zapatos Negros', 1500, 20),
(77, 'zapatos2.jpg', 'Zapatos Cafe', 1300, 20),
(78, 'camisa.jpg', 'Camisa Blanca ', 900, 20),
(98, 'saco.jpg', 'Saco Negro ', 2000, 20);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

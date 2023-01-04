-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 04 Oca 2023, 19:19:54
-- Sunucu sürümü: 5.7.40
-- PHP Sürümü: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `hastanedb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_branslar`
--

DROP TABLE IF EXISTS `tbl_branslar`;
CREATE TABLE IF NOT EXISTS `tbl_branslar` (
  `bransid` tinyint(4) NOT NULL AUTO_INCREMENT,
  `bransad` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`bransid`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `tbl_branslar`
--

INSERT INTO `tbl_branslar` (`bransid`, `bransad`) VALUES
(1, 'Dahiliye'),
(6, 'cilt hastaliklari'),
(3, 'Kulak Burun Boğaz'),
(11, ''),
(8, 'fizik tedavi'),
(10, ''),
(12, ''),
(13, ''),
(14, '');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_doktorlar`
--

DROP TABLE IF EXISTS `tbl_doktorlar`;
CREATE TABLE IF NOT EXISTS `tbl_doktorlar` (
  `Doktorid` tinyint(11) NOT NULL AUTO_INCREMENT,
  `DoktorAd` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DoktorSoyad` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DoktorBrans` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DoktorTC` char(11) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DoktorSifre` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`Doktorid`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `tbl_doktorlar`
--

INSERT INTO `tbl_doktorlar` (`Doktorid`, `DoktorAd`, `DoktorSoyad`, `DoktorBrans`, `DoktorTC`, `DoktorSifre`) VALUES
(13, 'ayça', 'gül', 'Dahiliye', '56565656566', '5656'),
(3, 'Hasan ', 'Yilmaz', 'Kulak Burun Bogaz ', '55555555555', '5554'),
(4, 'Sedat', 'Su', 'Dahiliye', '88888888888', '8888'),
(11, 'selen', 'akbaba', 'fizik tedavi', '36363636363', '6363'),
(6, 'İlknur', 'Doğan ', 'Cildiye', '44444444444', '4444');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_duyurular`
--

DROP TABLE IF EXISTS `tbl_duyurular`;
CREATE TABLE IF NOT EXISTS `tbl_duyurular` (
  `duyuruid` smallint(6) NOT NULL AUTO_INCREMENT,
  `duyuru` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`duyuruid`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `tbl_duyurular`
--

INSERT INTO `tbl_duyurular` (`duyuruid`, `duyuru`) VALUES
(1, 'saat 21:00\'de 102 no.2.\'de toplanti yapilacak.'),
(2, 'nöbet saatleri degisimi için takvim yayimlandi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_hastalar`
--

DROP TABLE IF EXISTS `tbl_hastalar`;
CREATE TABLE IF NOT EXISTS `tbl_hastalar` (
  `Hastaid` smallint(11) NOT NULL AUTO_INCREMENT,
  `hastaAd` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hastaSoyad` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hastaTC` char(11) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hastaTelefon` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hastaSifre` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hastaCinsiyet` varchar(5) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`Hastaid`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `tbl_hastalar`
--

INSERT INTO `tbl_hastalar` (`Hastaid`, `hastaAd`, `hastaSoyad`, `hastaTC`, `hastaTelefon`, `hastaSifre`, `hastaCinsiyet`) VALUES
(1, 'ARZU', 'ÇAKIR', '44444444444', '(444) 444-4455', '4444', 'KADIN'),
(2, 'murat', 'can', '99999999999', '(553) 252-5888', '2222', 'ERKEK'),
(3, 'simge', 'demirel', '55555555555', '(584) 422-2222', '5555', 'KADIN'),
(9, 'cansu', 'yavuz', '22222222222', '(052) 212-5555', '2222', 'KADIN');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_randevular`
--

DROP TABLE IF EXISTS `tbl_randevular`;
CREATE TABLE IF NOT EXISTS `tbl_randevular` (
  `randevu_id` int(11) NOT NULL AUTO_INCREMENT,
  `randevuTarih` varchar(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `randevuSaat` varchar(5) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `randevuBrans` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `randevudoktor` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `randevuDurum` bit(1) DEFAULT NULL,
  `HastaTC` char(11) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `hastasikayet` varchar(250) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`randevu_id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `tbl_randevular`
--

INSERT INTO `tbl_randevular` (`randevu_id`, `randevuTarih`, `randevuSaat`, `randevuBrans`, `randevudoktor`, `randevuDurum`, `HastaTC`, `hastasikayet`) VALUES
(1, '17.11.2021', '21:45', 'gafa', 'gafafa', NULL, NULL, ''),
(2, '06.11.2022', '09:30', 'Dahiliye', 'Sedat Su', NULL, NULL, ''),
(3, '12.05.2023', '10:30', 'Cildiye', 'Ilknur Dogan ', NULL, NULL, ''),
(4, '02.06.2023', '10:35', 'fizik tedavi', 'selen akbaba', NULL, NULL, ''),
(5, '12.12.2023', '09:10', 'Cildiye', 'Ilknur Dogan ', NULL, NULL, ''),
(6, '29.06.2023', '10:20', 'Dahiliye', 'Sedat Su', NULL, NULL, ''),
(7, '28.10.2023', '13:00', 'Dahiliye', 'Sedat Su', b'1', '44444444444', 'karnim agriyor'),
(8, '28.10.2023', '14:00', 'Dahiliye', 'Sedat Su', NULL, NULL, NULL),
(9, '28.10.2023', '15:00', 'Dahiliye', 'Sedat Su', NULL, NULL, NULL),
(10, '28.10.2023', '12:00', 'Kulak Burun Bogaz', 'Hasan  Yilmaz', NULL, NULL, NULL),
(11, '28.10.2023', '13:00', 'Kulak Burun Bogaz', 'Hasan  Yilmaz', b'1', '22222222222', 'duymuyorum'),
(12, '28.10.2023', '10:00', 'fizik tedavi', 'selen akbaba', NULL, NULL, NULL),
(13, '02.05.2023', '10:10', 'Dahiliye', 'ayça gül', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_sekreter`
--

DROP TABLE IF EXISTS `tbl_sekreter`;
CREATE TABLE IF NOT EXISTS `tbl_sekreter` (
  `Sekreterid` tinyint(4) NOT NULL AUTO_INCREMENT,
  `SekreterAdSoyad` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SekreterTC` char(11) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SekreterSifre` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`Sekreterid`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `tbl_sekreter`
--

INSERT INTO `tbl_sekreter` (`Sekreterid`, `SekreterAdSoyad`, `SekreterTC`, `SekreterSifre`) VALUES
(1, 'ayşe bayram', '55555555555', '1212'),
(2, 'sena aksu', '6666666', '6161');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

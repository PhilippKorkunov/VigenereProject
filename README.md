Автор: PhilippKorkunov

Проект выполнен на базе стека технологий asp.Net Razor Pages, который реализует шифр Виженера.
Проекст состоит из:
- директории Properties (идет по умолчанию)
- директории FileUploadDirectory, где:
	FileUploadService.cs - загрузка файла на сервер
	IFileUpload
	DeliteBeforeProcessing - отчистка от ненужных файлов
-директория Pages, где:
	Index.cshtml - главная страница
	Encryption.cshtml - страница для зашифровки
	Decryption.cshtml - страница для расшифровки
-директория VigenereDirectory, где
	KeyValidation.cs - валидация ключа
	TextParse.cs - обработка такста от пользователя
	VigenereCgipper - реализация шифра Виженера
-директория wwwroot - стандартная директория, где содержатся статичские ресурсы
	-Files - директория хранения файлов

Используемый вспомогательный софт DocX -пакет для взаимодействия с Word-документами.
Автор настоятельно просит не использовать DocX в коммерческих целях.


Значение для портов стоит по умолчанию.

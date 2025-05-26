# Информация об устройстве (WPF-приложение)

## Описание

Это простое приложение на WPF (C#), которое отображает информацию о вашем устройстве с использованием WMI (Windows Management Instrumentation).

### Отображаемая информация

- Количество установленных процессоров
- Название модели процессоров
- Количество планок оперативной памяти (ОЗУ)
- Название производителей планок ОЗУ
- Объём каждой планки ОЗУ

---

## Функционал

- **Обновить** — повторное получение информации
- **Копировать** — копирует данные в буфер обмена
- **Закрыть** — закрытие приложения

---

## Требования

- Windows 10 или новее
- .NET (9 или выше)

---

## Запуск

1. Откройте проект.
2. Убедитесь, что все зависимости установлены.
3. Постройте и запустите приложение.

---

## Документация

- [Microsoft Docs: System.Management.ManagementObjectSearcher](https://learn.microsoft.com/en-us/dotnet/api/system.management.managementobjectsearcher?view=net-9.0-pp)
- [Microsoft Docs: Connecting to WMI Remotely with C#](https://learn.microsoft.com/en-us/windows/win32/wmisdk/connecting-to-wmi-remotely-with-c-)
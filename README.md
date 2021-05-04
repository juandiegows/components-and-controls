# Componentes y Controles

Con este código será posible que tus formularios y controles tengan esquinas redondeadas, Que se puede mover, ya sea porque le has quitado el borde al formulario o porque quiere
que un control de mueva dentro de otro, todo eso lo puedes hacer en C #.

### Diferencia entre componentes y controles

Los controles se agregan al formulario y son parte visible de diseño mientras que los componentes están ocultos del diseño, pero les da súper poderes a los controles. me gusta exagera con decir súper poderes, pero si le da otros atributos al control o modifican el control.

## ¿Cómo usar el proyecto?

Al clonar el proyecto te va a salir esto.

![image](https://user-images.githubusercontent.com/65135568/116959811-0ba3e500-ac9f-11eb-9006-e53de548c6de.png)

No te asustes solo debes de compilar la solución y listo.

![image](https://user-images.githubusercontent.com/65135568/116959874-2d04d100-ac9f-11eb-8540-fa748c5727cb.png)

Debería salirte esto 

![image](https://user-images.githubusercontent.com/65135568/116959929-5291da80-ac9f-11eb-9842-8494e2af1d7a.png)

## 1- EllipseComponent

Redondea las esquina del formulario o cualquier control que se le asigne en su propiedad TargetControl

![image](https://user-images.githubusercontent.com/65135568/116960183-f11e3b80-ac9f-11eb-90e1-812ea1274470.png)

Pero en cualquier control diferente al **Form**, se debe definir los bordes del control enlazadas al contenedor, es decir que la propiedad **Dock** debe ser diferente a **none** para que tome los bordes, sin embargo puedes hacer uso del control **EllipseControl** para crear un panel con esquinas redondeadas.

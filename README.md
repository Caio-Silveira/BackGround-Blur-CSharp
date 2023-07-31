# BackGround-Blur-CSharp

# Usage Instructions - Blur Effect

This repository contains a C# code example that implements a blur effect for Windows Forms windows. The blur effect can be applied to a specific window, providing an elegant and modern appearance.

## How to Use the Code

1. Clone or download this repository to your computer.

2. Open the solution in Visual Studio or another C# development environment.

3. The code is divided into three sections defining the namespaces `Example`, `Blur`, and `W_APIs`.

   - The `W_APIs` namespace contains the necessary Windows API imports to apply the blur effect.
   - The `Blur` namespace contains a static method `SetBlur` that applies the blur effect to a specific window, taking the window handle (`handle`) as a parameter.
   - The `Main` namespace contains the `Main` class representing the main form of the application. In the `Main_Load` method, the blur effect is applied to the current window.

4. The `SetBlur` method is defined in the `Blur` class, which is static and does not need to be instantiated.

5. The `SetBlur` method is called in the `Main_Load` event of the `Main` form to apply the blur effect to the current window (`this.Handle`).

6. To test the blur effect, run the application. The main window should have a visual blur effect applied.

## Important Notes

- Make sure the project is properly configured with the Windows Forms platform and all necessary references.

- This example uses Windows API imports (in the `W_APIs` namespace) to apply the blur effect. Therefore, it is essential to be aware of compatibility and restrictions for different versions of Windows.

- If issues occur when applying the blur effect, verify that the Windows APIs are compatible with the version of the operating system on which the application is running.

## Video Example
[Watch the video demo here](https://streamable.com/pki9fj)

## Credits

This code example was created by [Caio Silveira](https://github.com/Caio-Silveira).

Feel free to use and modify the code in your own projects. If you encounter any issues or have suggestions for improvements, do not hesitate to open an issue or submit a pull request.

Enjoy coding! 😊

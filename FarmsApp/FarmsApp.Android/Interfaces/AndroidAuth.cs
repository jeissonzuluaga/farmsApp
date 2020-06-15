using Android.Gms.Extensions;
using FarmsApp.Droid.Interfaces;
using FarmsApp.Infraestructure;
using Firebase;
using Firebase.Auth;
using Java.Lang;
using System;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Xamarin.Forms;
using Exception = System.Exception;

[assembly : Dependency(typeof(AndroidAuth))]

namespace FarmsApp.Droid.Interfaces
{
    public class AndroidAuth : FirebaseAuthConn
    {
        public async Task<string> DoLoginWithUP(string correo, string contraseña)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(correo, contraseña);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (FirebaseAuthInvalidUserException notfound) 
            {
                return notfound.Message;
            }

            catch (Exception err)
            {
                return err.Message;
            }
            
        }

        public async Task<string> DoRegisterWithUP(string correo, string contraseña)
        {
            try
            {
                var user = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(correo, contraseña);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (FirebaseAuthInvalidUserException notfound)
            {
                return notfound.Message;
            }

            catch (Exception err)
            {
                return err.Message;
            }
        }
    }
}
### Deploy on Heroku
- Clone the project to your computer: ```git clone "https://github.com/makemefriendanshu/punecodegirls.git"```
- Create new app in Heroku ```heroku apps:create <app-name>```
- Add Heroku git remote to your project : ```heroku git:remote -a <app-name>```
- Set Heroku project to use contaier: ```heroku stack:set container```
- Push code to Heroku: ```git push heroku master```
- Scale worker dyno: ```heroku ps:scale worker1=1```
- Verify worker and web dynos are running: ```heroku ps```
- Open website: ```heroku open```

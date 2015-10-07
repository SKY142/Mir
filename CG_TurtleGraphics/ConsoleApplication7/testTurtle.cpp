#include <iostream>
using namespace std;

#include <glut.h>
//#include "supportedClass.h"
#include"Turtle.h"


//Turtle ninja(Point2(0,0),90);
Turtle ninja;
void drawArc(Point2 center, float radius, float startAngle, float sweep)
{
	const int n = 30;
	float angle = startAngle * 3.14149265 / 180;
	float angleInc = sweep * 3.14149265 / (180*n);
	float cx = center.getX(),cy = center.getY();
	ninja.moveTo(cx+radius*cos(angle),cy+radius * sin(angle));
	for(int k = 1;k<n;k++,angle += angleInc)
		ninja.lineTo(Point2(cx+radius * cos(angle),cy + radius * sin(angle)));
}
void ngon(int n,double cx,double cy,double radius,double rotAngle)
{
	if(n<3)
	{
		return;
	}
	double angle = rotAngle * (3.145/180);
	double angleInc = 2 * (3.145/n);
	ninja.moveTo(radius*cos(angle)+cx,radius*sin(angle)+cy);
	for(int k=0;k<n;k++)
	{
		angle += angleInc;
		ninja.lineTo(radius*cos(angle)+cx,radius * sin(angle)+cy);
	}
}
void drawHook()
{
	float L = 4;
	for(int i=0;i<4;i++)
	{
	ninja.forward(3*L,true);
	ninja.turnLeft(90);
	ninja.forward(L,true);
	ninja.turnLeft(90);
	ninja.forward(L,true);
	ninja.turnLeft(90);
	}
}
void drawMitsubishilogo()
{
	float L = 4;
	ninja.setTurnAngle(60);
	ninja.forward(2*L,true);
	ninja.setTurnAngle(120.0);
	ninja.forward(L,1);
	ninja.setTurnAngle(240.0);
	ninja.forward(L,1);
	ninja.setTurnAngle(300.0);
	ninja.forward(2*L,1);
	ninja.setTurnAngle(0.0);
	ninja.forward(L,1);
	ninja.setTurnAngle(120.0);
	ninja.forward(L,1);
	ninja.setTurnAngle(180.0);
	ninja.forward(2*L,1);
	ninja.setTurnAngle(240.0);
	ninja.forward(L,1);
	ninja.setTurnAngle(0.0);
	ninja.forward(L,1);

}
void drawPolyspiral()
{
	float L = 0.1;
	float angle = 89.5;
	for(int i =0;i<100;i++)
	{
		ninja.forward(L,1);
		ninja.turnRight(angle);
		L += 0.1;
		
	}
}
void display(void) {



    glClear( GL_COLOR_BUFFER_BIT );
	//drawMitsubishilogo();
	drawPolyspiral();
	//drawHook();
	/*ninja.setCurrentState(Point2(0,0),0,2);
	ninja.setStepLength(15);
	ninja.setTurnAngle(45);
	ninja.lineTo(Point2(2,2));
	
	
	ninja.setCurrentState(Point2(2,0),90,2);
	ninja.forward(true);
	*/		//drawArc(Point2(0.0,0.0),10,30,100);	
	//ngon(side,0,0,10,0);
 	glFlush(); /* force OpenGL output */
}


/*
 * myReshape
 *
 * This function is called whenever the user (or OS) reshapes the
 * OpenGL window. The GLUT sends the new window dimensions (x,y)
 *
 */
void myReshape(int w, int h)
{
	/* set viewport to new width and height */
	/* note that this command does not change the CTM */
    glViewport(0, 0, w, h);

	/* 
	 * set viewing window in world coordinates 
	 */
    glMatrixMode(GL_PROJECTION); 
    glLoadIdentity(); /* init projection matrix */

	gluOrtho2D(-40,40,-40,40);
    /*if (w <= h)
        gluOrtho2D(-2.0, 2.0, -2.0 * (GLfloat) h / (GLfloat) w, 2.0 * (GLfloat) h / (GLfloat) w);
		
    else
        gluOrtho2D(-2.0 * (GLfloat) w / (GLfloat) h, 2.0 * (GLfloat) w / (GLfloat) h, -2.0, 2.0);

	/* set matrix mode to modelview */
    glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
}


void myKey(unsigned char k, int x, int y)
{
	switch (k) {
		case 'q':
		case 'Q':	
			exit(0);
			break;
		default:
			printf("Unknown keyboard command \'%c\'.\n", k);
			break;
	}
}



int main(int argc, char **argv)
{
	/*printf("Enter Sides:");
	scanf("%d",&side);*/

	/* glutInit MUST be called before any other GLUT/OpenGL calls */
    glutInit(&argc, argv);

	/* need both double buffering and z buffer */

    glutInitDisplayMode(GLUT_RGB);
    glutInitWindowSize(800, 600);
    glutCreateWindow("The Turtle");

	/* set callback functions */
    glutReshapeFunc(myReshape);
    glutDisplayFunc(display);
	//glutKeyboardFunc(myKey);
//	glutTimerFunc(GAP, myTimer, 0);

	/* set clear colour */
	glClearColor(1.0, 1.0, 1.0, 1.0);

	/* set current colour to black */
	glColor3f(0.0, 0.0, 0.0);

    glutMainLoop();

	return 0;
}


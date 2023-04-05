#version 400 core

in vec3 position;
in vec2 coordinate;

uniform mat4 transform;
uniform mat4 view;
uniform mat4 projection;

uniform float surprise_angle;

out vec2 pass_c1;
out vec2 pass_c2;

void main(void){
    gl_Position=projection*view*transform*vec4(position,1.0);
    float angle=(3.1415926/2.0)*coordinate.x+3.1415926*coordinate.y+surprise_angle;
    float cx=(sin(angle)+1.0)/2.0;
    float cy=(cos(angle)+1.0)/2.0;
    pass_c1=vec2(cx,cy);
    pass_c2=coordinate;
}
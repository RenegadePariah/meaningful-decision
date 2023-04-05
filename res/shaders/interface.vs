#version 400 core

in vec2 position;

uniform mat4 transform;

out vec2 tex_coord;
void main(void){
	gl_Position = transform*vec4(position, 0.0, 1.0);
	tex_coord = vec2((position.x+1.0)/2.0, 1.0 - (position.y+1.0)/2.0);
}
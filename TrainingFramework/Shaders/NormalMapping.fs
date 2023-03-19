precision mediump float;

uniform sampler2D u_texture;

varying vec2 v_uv;
varying vec3 vColor;

void main()
{
//	gl_FragColor = vec4(1.0, 0.0, 0.0, 1.0);
//	gl_FragColor = vec4(vColor, 1.0);
	gl_FragColor = texture2D(u_texture, v_uv);
}

extends CharacterBody3D
const SPEED = 20.0
const ACCELERATION = 20
const FRICTION = 2
const JUMP_VELOCITY = 10

var gravity = ProjectSettings.get_setting("physics/3d/default_gravity") # gravity from project settings

func _physics_process(delta):
 apply_gravity(delta)
 movement(delta)
 move_and_slide()
 apply_jump()

func apply_gravity(delta):
 if not is_on_floor():
  velocity.y -= gravity * delta 

func movement(delta):
 var input_dir = Input.get_vector("move_right", "move_left", "move_down", "move_up")
 var direction = (transform.basis * Vector3(input_dir.x, 0, input_dir.y)).normalized()
 if direction:
  apply_velocity(direction, delta)
 else:
  apply_friction(direction, delta) 

# velocity with acceleration
func apply_velocity(direction, delta):
 velocity.x = move_toward(velocity.x, direction.x * SPEED, ACCELERATION * delta)
 velocity.z = move_toward(velocity.z, direction.z * SPEED, ACCELERATION * delta)
# deceleration through friction
func apply_friction(direction, delta):
 velocity.x = move_toward(velocity.x, 0, FRICTION)
 velocity.z = move_toward(velocity.z, 0, FRICTION)

func apply_jump():
 if is_on_floor():
  if Input.is_action_just_pressed("ui_accept"):
   velocity.y = JUMP_VELOCITY

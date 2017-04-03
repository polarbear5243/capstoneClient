S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 6642
Date: 2017-04-01 20:28:12+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6642, uid 5000)

Register Information
r0   = 0xbee88f20, r1   = 0x8004703e
r2   = 0x000003e7, r3   = 0x8004703e
r4   = 0x00000000, r5   = 0x8004703e
r6   = 0x000003e7, r7   = 0xb284bf62
r8   = 0xbee8903c, r9   = 0xbee88fc8
r10  = 0xb8b4cab8, fp   = 0x00000000
ip   = 0xb6814ca0, sp   = 0xbee88f10
lr   = 0xb674ae14, pc   = 0xb67462ec
cpsr = 0xa0000010

Memory Information
MemTotal:   987012 KB
MemFree:     41772 KB
Buffers:     43700 KB
Cached:     273616 KB
VmPeak:     136352 KB
VmSize:     131896 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32580 KB
VmRSS:       29556 KB
VmData:      47476 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35732 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6642 TID = 6642
6642 6643 8416 8417 8427 

Maps Information
afd03000 b06d5000 rw-p [stack:8427]
b130b000 b131c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b132c000 b1331000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13f6000 b13fe000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1410000 b1c0f000 rw-p [stack:8417]
b1c0f000 b1c10000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c20000 b1c34000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c48000 b1c49000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c59000 b1c5c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c6d000 b1c6e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c7e000 b1c80000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c90000 b1c92000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1ca2000 b1cb2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cc2000 b1cce000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ce0000 b24df000 rw-p [stack:8416]
b2810000 b2817000 r-xp /usr/lib/libefl-extension.so.0.1.0
b282a000 b2830000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2840000 b2850000 r-xp /opt/usr/apps/org.example.client/bin/client
b29a8000 b2a8b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ac2000 b2aea000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2afc000 b32fb000 rw-p [stack:6643]
b32fb000 b32fd000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b330d000 b3317000 r-xp /lib/libnss_files-2.20-2014.11.so
b3328000 b3331000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3342000 b3353000 r-xp /lib/libnsl-2.20-2014.11.so
b3366000 b336c000 r-xp /lib/libnss_compat-2.20-2014.11.so
b337d000 b337e000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33a6000 b33ad000 r-xp /usr/lib/libminizip.so.1.0.0
b33bd000 b33c2000 r-xp /usr/lib/libstorage.so.0.1
b33d2000 b3431000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3447000 b345b000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b346b000 b34af000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34bf000 b34c7000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34d7000 b3507000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b351a000 b35d3000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35e7000 b363a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b364b000 b3666000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3676000 b3737000 r-xp /usr/lib/libprotobuf.so.9.0.1
b374a000 b375a000 r-xp /usr/lib/libefl-assist.so.0.1.0
b376a000 b3777000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3788000 b378f000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b379f000 b37e0000 r-xp /usr/lib/libmdm.so.1.2.12
b37f0000 b37f8000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3807000 b3817000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3838000 b3898000 r-xp /usr/lib/libasound.so.2.0.0
b38aa000 b38ad000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38bd000 b38c0000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38d0000 b38d5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38e5000 b38e6000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38f6000 b3901000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3915000 b391c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b392c000 b3932000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3942000 b3947000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3957000 b3972000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3982000 b3989000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3999000 b399c000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39ad000 b39db000 r-xp /usr/lib/libidn.so.11.5.44
b39eb000 b3a01000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a12000 b3a1c000 r-xp /usr/lib/libcares.so.2.1.0
b3a2c000 b3a36000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a46000 b3a48000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a58000 b3a59000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a69000 b3a6d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a7e000 b3aa6000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ab7000 b3ae0000 r-xp /usr/lib/libturbojpeg.so
b3b00000 b3b06000 r-xp /usr/lib/libgif.so.4.1.6
b3b16000 b3b5c000 r-xp /usr/lib/libcurl.so.4.3.0
b3b6d000 b3b8e000 r-xp /usr/lib/libexif.so.12.3.3
b3ba9000 b3bbe000 r-xp /usr/lib/libtts.so
b3bcf000 b3bd7000 r-xp /usr/lib/libfeedback.so.0.1.4
b3be7000 b3cad000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ccd000 b3dc5000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3de4000 b3eb2000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ec9000 b3ecb000 r-xp /usr/lib/libboost_system.so.1.51.0
b3edb000 b3ee1000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ef1000 b3f14000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f25000 b3f27000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f37000 b3f39000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f4a000 b3f4f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f66000 b3f68000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f78000 b3f7f000 r-xp /usr/lib/libsensord-share.so
b3f8f000 b3fa7000 r-xp /usr/lib/libsensor.so.1.1.0
b3fb8000 b3fbb000 r-xp /usr/lib/libXv.so.1.0.0
b3fcb000 b3fd0000 r-xp /usr/lib/libutilX.so.1.1.0
b3fe0000 b3fe5000 r-xp /usr/lib/libappcore-common.so.1.1
b3ff5000 b3ffc000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b400f000 b4013000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4024000 b4102000 r-xp /usr/lib/libCOREGL.so.4.0
b4122000 b4125000 r-xp /usr/lib/libuuid.so.1.3.0
b4135000 b414c000 r-xp /usr/lib/libblkid.so.1.1.0
b415d000 b415f000 r-xp /usr/lib/libXau.so.6.0.0
b416f000 b41b6000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41c8000 b41ce000 r-xp /usr/lib/libjson-c.so.2.0.1
b41df000 b41e3000 r-xp /usr/lib/libogg.so.0.7.1
b41f3000 b4215000 r-xp /usr/lib/libvorbis.so.0.4.3
b4225000 b4309000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4325000 b4328000 r-xp /usr/lib/libEGL.so.1.4
b4339000 b433f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b434f000 b4351000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4361000 b436e000 r-xp /usr/lib/libGLESv2.so.2.0
b437f000 b43e1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43f6000 b440e000 r-xp /usr/lib/libmount.so.1.1.0
b4420000 b4434000 r-xp /usr/lib/libxcb.so.1.1.0
b4444000 b444b000 r-xp /lib/libcrypt-2.20-2014.11.so
b4483000 b4485000 r-xp /usr/lib/libiri.so
b4495000 b44a0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44b1000 b44e7000 r-xp /usr/lib/libpulse.so.0.16.2
b44f8000 b453b000 r-xp /usr/lib/libsndfile.so.1.0.25
b4550000 b4565000 r-xp /lib/libexpat.so.1.5.2
b4577000 b4635000 r-xp /usr/lib/libcairo.so.2.11200.14
b4649000 b4651000 r-xp /usr/lib/libdrm.so.2.4.0
b4661000 b4664000 r-xp /usr/lib/libdri2.so.0.0.0
b4674000 b46c2000 r-xp /usr/lib/libssl.so.1.0.0
b46d7000 b46e3000 r-xp /usr/lib/libeeze.so.1.13.0
b46f4000 b46fd000 r-xp /usr/lib/libethumb.so.1.13.0
b470d000 b4710000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4720000 b48d7000 r-xp /usr/lib/libcrypto.so.1.0.0
b56c2000 b56cb000 r-xp /usr/lib/libXi.so.6.1.0
b56db000 b56dd000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ed000 b56f1000 r-xp /usr/lib/libXtst.so.6.1.0
b5701000 b5707000 r-xp /usr/lib/libXrender.so.1.3.0
b5717000 b571d000 r-xp /usr/lib/libXrandr.so.2.2.0
b572d000 b572f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5740000 b5743000 r-xp /usr/lib/libXfixes.so.3.1.0
b5753000 b575e000 r-xp /usr/lib/libXext.so.6.4.0
b576e000 b5770000 r-xp /usr/lib/libXdamage.so.1.1.0
b5780000 b5782000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5792000 b5874000 r-xp /usr/lib/libX11.so.6.3.0
b5888000 b588f000 r-xp /usr/lib/libXcursor.so.1.0.2
b589f000 b58b7000 r-xp /usr/lib/libudev.so.1.6.0
b58b9000 b58bc000 r-xp /lib/libattr.so.1.1.0
b58cc000 b58ec000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ed000 b58f2000 r-xp /usr/lib/libffi.so.6.0.2
b5903000 b591b000 r-xp /lib/libz.so.1.2.8
b592b000 b592d000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b593d000 b5a12000 r-xp /usr/lib/libxml2.so.2.9.2
b5a27000 b5ac2000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ade000 b5ae1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5af1000 b5b0a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b1b000 b5b2c000 r-xp /lib/libresolv-2.20-2014.11.so
b5b40000 b5bba000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bcf000 b5bd1000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5be1000 b5be8000 r-xp /usr/lib/libembryo.so.1.13.0
b5bf8000 b5c02000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c13000 b5c2b000 r-xp /usr/lib/libpng12.so.0.50.0
b5c3c000 b5c5f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c80000 b5c94000 r-xp /usr/lib/libector.so.1.13.0
b5ca5000 b5cbd000 r-xp /usr/lib/liblua-5.1.so
b5cce000 b5d25000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d39000 b5d61000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d72000 b5d85000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d96000 b5dd0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5de1000 b5def000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dff000 b5e07000 r-xp /usr/lib/libtbm.so.1.0.0
b5e17000 b5e24000 r-xp /usr/lib/libeio.so.1.13.0
b5e34000 b5e36000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e46000 b5e4b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e5b000 b5e72000 r-xp /usr/lib/libefreet.so.1.13.0
b5e84000 b5ea4000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eb4000 b5ed4000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ed6000 b5edc000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eec000 b5efd000 r-xp /usr/lib/libemotion.so.1.13.0
b5f0e000 b5f15000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f25000 b5f34000 r-xp /usr/lib/libeo.so.1.13.0
b5f45000 b5f57000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f68000 b5f6d000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f7d000 b5f96000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fa6000 b5fc3000 r-xp /usr/lib/libeet.so.1.13.0
b5fdc000 b6024000 r-xp /usr/lib/libeina.so.1.13.0
b6035000 b6045000 r-xp /usr/lib/libefl.so.1.13.0
b6056000 b613b000 r-xp /usr/lib/libicuuc.so.51.1
b6158000 b6298000 r-xp /usr/lib/libicui18n.so.51.1
b62af000 b62e7000 r-xp /usr/lib/libecore_x.so.1.13.0
b62f9000 b62fc000 r-xp /lib/libcap.so.2.21
b630c000 b6335000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6346000 b634d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b635f000 b6396000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63a7000 b6492000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64a5000 b651e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6530000 b6535000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6545000 b654f000 r-xp /usr/lib/libvconf.so.0.2.45
b655f000 b6561000 r-xp /usr/lib/libvasum.so.0.3.1
b6571000 b6573000 r-xp /usr/lib/libttrace.so.1.1
b6583000 b6586000 r-xp /usr/lib/libiniparser.so.0
b6596000 b65bc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65cc000 b65d1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65e2000 b65f9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b660a000 b6675000 r-xp /lib/libm-2.20-2014.11.so
b6686000 b668c000 r-xp /lib/librt-2.20-2014.11.so
b669d000 b66aa000 r-xp /usr/lib/libunwind.so.8.0.1
b66e0000 b6804000 r-xp /lib/libc-2.20-2014.11.so
b6819000 b6832000 r-xp /lib/libgcc_s-4.9.so.1
b6842000 b6924000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6935000 b695f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6970000 b69ac000 r-xp /usr/lib/libsystemd.so.0.4.0
b69ae000 b6a31000 r-xp /usr/lib/libedje.so.1.13.0
b6a44000 b6a62000 r-xp /usr/lib/libecore.so.1.13.0
b6a82000 b6c09000 r-xp /usr/lib/libevas.so.1.13.0
b6c3e000 b6c52000 r-xp /lib/libpthread-2.20-2014.11.so
b6c66000 b6e9a000 r-xp /usr/lib/libelementary.so.1.13.0
b6ec9000 b6ecd000 r-xp /usr/lib/libsmack.so.1.0.0
b6edd000 b6ee4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ef4000 b6ef6000 r-xp /usr/lib/libdlog.so.0.0.0
b6f06000 b6f09000 r-xp /usr/lib/libbundle.so.0.1.22
b6f19000 b6f1b000 r-xp /lib/libdl-2.20-2014.11.so
b6f2c000 b6f44000 r-xp /usr/lib/libaul.so.0.1.0
b6f58000 b6f5d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f6e000 b6f7b000 r-xp /usr/lib/liblptcp.so
b6f8d000 b6f91000 r-xp /usr/lib/libsys-assert.so
b6fa2000 b6fc2000 r-xp /lib/ld-2.20-2014.11.so
b6fd3000 b6fd8000 r-xp /usr/bin/launchpad-loader
b8828000 b8c00000 rw-p [heap]
bee69000 bee8a000 rw-p [stack]
b8828000 b8c00000 rw-p [heap]
bee69000 bee8a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6642)
Call Stack Count: 1
 0: vsnprintf + 0x74 (0xb67462ec) [/lib/libc.so.6] + 0x662ec
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
605): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(878), cmd(0)
04-01 20:28:02.090+0900 W/AUL     (  715): launch.c: app_request_to_launchpad(425) > request cmd(0) result(878)
04-01 20:28:02.090+0900 E/STARTER (  715): dbus-util.c: starter_dbus_home_raise_signal_send(219) > [starter_dbus_home_raise_signal_send:219] Sending HOME RAISE signal, result:0
04-01 20:28:02.090+0900 I/APP_CORE(  878): appcore-efl.c: __do_app(564) > Legacy lifecycle: 0
04-01 20:28:02.090+0900 I/APP_CORE(  878): appcore-efl.c: __do_app(566) > [APP 878] App already running, raise the window
04-01 20:28:02.100+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(878) status(3)
04-01 20:28:02.110+0900 W/AUL_AMD (  605): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 20:28:02.110+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-01 20:28:02.110+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(878)
04-01 20:28:02.110+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 878, appid: com.samsung.homescreen, status: fg
04-01 20:28:02.130+0900 W/HOME_APPS(  878): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-01 20:28:02.160+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 20:28:02.160+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 20:28:02.170+0900 I/APP_CORE(  878): appcore-efl.c: __do_app(514) > [APP 878] Event: RESUME State: PAUSED
04-01 20:28:02.170+0900 I/CAPI_APPFW_APPLICATION(  878): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 20:28:02.170+0900 E/cluster-home(  878): homescreen.cpp: OnResume(233) >  app resume
04-01 20:28:02.180+0900 I/Tizen::System( 1247): (259) > Active app [com.samsun], current [com.samsun] 
04-01 20:28:02.180+0900 I/Tizen::System( 1247): (273) > Current App[com.samsun] is already actived.
04-01 20:28:02.180+0900 I/APP_CORE( 6825): appcore-efl.c: __do_app(514) > [APP 6825] Event: PAUSE State: RUNNING
04-01 20:28:02.180+0900 I/CAPI_APPFW_APPLICATION( 6825): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-01 20:28:02.180+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(6825) status(4)
04-01 20:28:02.190+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 20:28:02.190+0900 E/weather-widget( 1420): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-01 20:28:02.200+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(3878) status(4)
04-01 20:28:02.200+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.setting(3878)
04-01 20:28:02.200+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3878, appid: com.samsung.setting, status: bg
04-01 20:28:02.200+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.setting.developer(6825)
04-01 20:28:02.200+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6825, appid: com.samsung.setting.developer, status: bg
04-01 20:28:02.210+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 6825): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 31
04-01 20:28:02.210+0900 E/APP_CORE( 6825): appcore-efl.c: _capture_and_make_file(1619) > win[7e00003] widget[720] height[1280]
04-01 20:28:02.210+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 33
04-01 20:28:02.210+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 20:28:02.220+0900 E/weather-widget( 1420): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-01 20:28:02.260+0900 E/weather-common( 1420): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-01 20:28:02.310+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_create(409) > New handle created[0xb8c74038]
04-01 20:28:02.310+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_get_type(463) > Connected Network = 2
04-01 20:28:02.310+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_destroy(427) > Destroy handle: 0xb8c74038
04-01 20:28:02.310+0900 E/weather-common( 1420): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-01 20:28:02.310+0900 E/weather-widget( 1420): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-01 20:28:02.310+0900 I/CAPI_WIDGET_APPLICATION( 1420): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-01 20:28:02.310+0900 I/CAPI_WIDGET_APPLICATION( 1420): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-01 20:28:02.310+0900 W/AUL     ( 1420): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1420, appid: com.samsung.weather-m-widget, status: fg
04-01 20:28:02.451+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.700
04-01 20:28:03.462+0900 E/EFL     (  878): ecore_x<878> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=22692234
04-01 20:28:03.462+0900 E/cluster-view(  878): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
04-01 20:28:03.462+0900 E/EFL     (  859): ecore_x<859> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=22692234
04-01 20:28:03.462+0900 W/STARTER (  715): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
04-01 20:28:03.462+0900 W/STARTER (  715): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
04-01 20:28:03.772+0900 I/SYSPOPUP(  871): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-01 20:28:03.772+0900 E/STARTER (  715): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-01 20:28:03.772+0900 E/STARTER (  715): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-01 20:28:03.772+0900 E/STARTER (  715): )
04-01 20:28:03.772+0900 I/SYSPOPUP(  871): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-01 20:28:03.772+0900 E/VOLUME  (  871): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-01 20:28:03.772+0900 E/VOLUME  (  871): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-01 20:28:03.792+0900 W/AUL     (  715): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
04-01 20:28:03.792+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 0
04-01 20:28:03.802+0900 I/AUL     (  605): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
04-01 20:28:03.802+0900 E/AUL_AMD (  605): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-01 20:28:03.802+0900 W/AUL_AMD (  605): amd_launch.c: _start_app(2508) > caller pid : 715
04-01 20:28:03.802+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-01 20:28:03.812+0900 E/RESOURCED(  685): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 20:28:03.832+0900 I/GXT_SIB (  340): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-01 20:28:03.842+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bfb6e9 in class 'Edje_Object'.
04-01 20:28:03.842+0900 E/UXT     (  340): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
04-01 20:28:03.842+0900 W/AUL_AMD (  605): amd_launch.c: _start_app(3052) > pad pid(-5)
04-01 20:28:03.842+0900 W/AUL_PAD ( 1508): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-01 20:28:03.842+0900 W/AUL_PAD ( 1508): launchpad.c: __send_result_to_caller(267) > Check app launching
04-01 20:28:03.862+0900 E/CAPI_APPFW_APPLICATION( 8138): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-01 20:28:03.862+0900 E/CAPI_APPFW_APPLICATION( 8138): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-01 20:28:03.862+0900 E/CAPI_APPFW_APPLICATION( 8138): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-01 20:28:03.862+0900 E/CAPI_APPFW_APPLICATION( 8138): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-01 20:28:03.862+0900 E/CAPI_APPFW_APPLICATION( 8138): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
04-01 20:28:03.862+0900 I/CAPI_APPFW_APPLICATION( 8138): app_main.c: ui_app_main(789) > app_efl_main
04-01 20:28:03.862+0900 I/CAPI_APPFW_APPLICATION( 8138): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-01 20:28:03.942+0900 W/TASK_MGR_LITE( 8138): task-mgr-lite.c: create_win(197) > changeable ui enabled success
04-01 20:28:03.942+0900 I/GXT_SIB ( 8138): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
04-01 20:28:03.942+0900 W/AUL     (  605): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8138, appid: com.samsung.task-mgr
04-01 20:28:03.942+0900 E/AUL     (  605): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-01 20:28:03.952+0900 W/AUL     (  715): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8138)
04-01 20:28:03.952+0900 E/RESOURCED(  685): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
04-01 20:28:03.992+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 20:28:03.992+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 20:28:04.012+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.022+0900 I/Tizen::System( 1247): (259) > Active app [com.samsun], current [com.samsun] 
04-01 20:28:04.022+0900 I/Tizen::System( 1247): (273) > Current App[com.samsun] is already actived.
04-01 20:28:04.032+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.032+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 20:28:04.042+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.042+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 12
04-01 20:28:04.062+0900 E/RUA     ( 8138): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 23, ncols : 5
04-01 20:28:04.062+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 6642
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 12
04-01 20:28:04.062+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 3878
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 12
04-01 20:28:04.062+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
04-01 20:28:04.062+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 6795
04-01 20:28:04.062+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 12
04-01 20:28:04.072+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 20:28:04.072+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 1471
04-01 20:28:04.072+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 12
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
04-01 20:28:04.072+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 20:28:04.072+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5417
04-01 20:28:04.072+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 12
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.oma-dm-noti) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
04-01 20:28:04.072+0900 E/TASK_MGR_LITE( 8138): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
04-01 20:28:04.072+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.092+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.112+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.122+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.142+0900 I/APP_CORE( 8138): appcore-efl.c: __do_app(514) > [APP 8138] Event: RESET State: CREATED
04-01 20:28:04.142+0900 I/CAPI_APPFW_APPLICATION( 8138): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-01 20:28:04.142+0900 E/EFL     ( 8138): edje<8138> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 20:28:04.142+0900 E/EFL     ( 8138): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 20:28:04.142+0900 E/EFL     ( 8138): edje<8138> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 20:28:04.142+0900 E/EFL     ( 8138): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 20:28:04.142+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.142+0900 W/APP_CORE( 8138): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8800003
04-01 20:28:04.152+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 35
04-01 20:28:04.162+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.172+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.302+0900 E/EFL     (  859): ecore_x<859> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=22693077
04-01 20:28:04.302+0900 W/STARTER (  715): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-01 20:28:04.302+0900 E/EFL     (  878): ecore_x<878> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=22693077
04-01 20:28:04.302+0900 E/cluster-view(  878): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
04-01 20:28:04.312+0900 E/STARTER (  715): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-01 20:28:04.312+0900 E/STARTER (  715): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-01 20:28:04.312+0900 E/STARTER (  715): )
04-01 20:28:04.312+0900 I/SYSPOPUP(  871): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-01 20:28:04.312+0900 I/SYSPOPUP(  871): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-01 20:28:04.312+0900 E/VOLUME  (  871): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-01 20:28:04.312+0900 E/VOLUME  (  871): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-01 20:28:04.332+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(8138) status(0)
04-01 20:28:04.332+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(8138) status(0)
04-01 20:28:04.332+0900 I/APP_CORE(  878): appcore-efl.c: __do_app(514) > [APP 878] Event: PAUSE State: RUNNING
04-01 20:28:04.332+0900 I/CAPI_APPFW_APPLICATION(  878): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-01 20:28:04.332+0900 E/cluster-home(  878): homescreen.cpp: OnPause(260) >  app pause
04-01 20:28:04.342+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(878) status(4)
04-01 20:28:04.342+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(878)
04-01 20:28:04.342+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 878, appid: com.samsung.homescreen, status: bg
04-01 20:28:04.342+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(8138) status(3)
04-01 20:28:04.342+0900 W/AUL_AMD (  605): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 20:28:04.342+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-01 20:28:04.342+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(8138)
04-01 20:28:04.342+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8138, appid: com.samsung.task-mgr, status: fg
04-01 20:28:04.352+0900 E/EFL     (  340): evas-gl_x11<340> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-01 20:28:04.362+0900 I/CAPI_WIDGET_APPLICATION( 1420): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-01 20:28:04.362+0900 I/CAPI_WIDGET_APPLICATION( 1420): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-01 20:28:04.362+0900 W/AUL     ( 1420): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1420, appid: com.samsung.weather-m-widget, status: bg
04-01 20:28:04.372+0900 I/APP_CORE( 8138): appcore-efl.c: __do_app(514) > [APP 8138] Event: RESUME State: CREATED
04-01 20:28:04.382+0900 I/APP_CORE( 8138): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-01 20:28:04.382+0900 I/APP_CORE( 8138): appcore-efl.c: __do_app(625) > [APP 8138] Initial Launching, call the resume_cb
04-01 20:28:04.382+0900 I/CAPI_APPFW_APPLICATION( 8138): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 20:28:04.993+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.702
04-01 20:28:05.003+0900 I/Tizen::App( 1247): (499) > LaunchedApp(com.samsung.task-mgr)
04-01 20:28:05.003+0900 I/Tizen::App( 1247): (733) > Finished invoking application event listener for com.samsung.task-mgr, 8138.
04-01 20:28:05.283+0900 I/APP_CORE( 6642): appcore-efl.c: __do_app(514) > [APP 6642] Event: MEM_FLUSH State: PAUSED
04-01 20:28:05.584+0900 E/EFL     ( 8138): ecore_x<8138> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=22694357
04-01 20:28:05.584+0900 E/TASK_MGR_LITE( 8138): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
04-01 20:28:05.684+0900 E/EFL     ( 8138): ecore_x<8138> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=22694456
04-01 20:28:05.684+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 20:28:05.684+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 6642
04-01 20:28:05.684+0900 W/AUL     ( 8138): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-01 20:28:05.694+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 1
04-01 20:28:05.694+0900 W/AUL_AMD (  605): amd_launch.c: _start_app(2508) > caller pid : 8138
04-01 20:28:05.704+0900 W/AUL     (  605): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 6642, appid: org.example.client
04-01 20:28:05.704+0900 W/AUL_AMD (  605): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 1, pid: 6642
04-01 20:28:05.704+0900 W/AUL_AMD (  605): amd_launch.c: _resume_app(924) > resume done
04-01 20:28:05.714+0900 W/AUL_AMD (  605): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(6642), cmd(3)
04-01 20:28:05.714+0900 W/AUL     ( 8138): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6642)
04-01 20:28:05.714+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(6642) status(3)
04-01 20:28:05.724+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6642)
04-01 20:28:05.724+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6642, appid: org.example.client, status: fg
04-01 20:28:05.764+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(6642) status(0)
04-01 20:28:05.784+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3400002 FAILED!
04-01 20:28:05.784+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3400002 FAILED!
04-01 20:28:05.784+0900 I/ISE_MULTI(  858): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:true] mode=1[0m
04-01 20:28:05.784+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 20:28:05.784+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 20:28:05.794+0900 I/SWIFTKEY(  712): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-01 20:28:05.794+0900 W/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
04-01 20:28:05.794+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 20:28:05.814+0900 I/Tizen::System( 1247): (259) > Active app [org.exampl], current [com.samsun] 
04-01 20:28:05.814+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 20:28:05.814+0900 I/APP_CORE( 8138): appcore-efl.c: __do_app(514) > [APP 8138] Event: PAUSE State: RUNNING
04-01 20:28:05.814+0900 I/CAPI_APPFW_APPLICATION( 8138): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-01 20:28:05.814+0900 W/TASK_MGR_LITE( 8138): task-mgr-lite.c: _pause_app(406) > 
04-01 20:28:05.824+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 33
04-01 20:28:05.824+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(8138) status(4)
04-01 20:28:05.824+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(8138)
04-01 20:28:05.824+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8138, appid: com.samsung.task-mgr, status: bg
04-01 20:28:05.834+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 22
04-01 20:28:05.834+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(1201) > app status : 5
04-01 20:28:05.834+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 20:28:05.834+0900 I/CAPI_APPFW_APPLICATION( 8138): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-01 20:28:05.834+0900 E/TASK_MGR_LITE( 8138): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-01 20:28:05.854+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
04-01 20:28:05.854+0900 I/APP_CORE( 6642): appcore-efl.c: __do_app(514) > [APP 6642] Event: RESUME State: PAUSED
04-01 20:28:05.854+0900 I/CAPI_APPFW_APPLICATION( 6642): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 20:28:05.854+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-01 20:28:05.874+0900 E/APP_CORE( 8138): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-01 20:28:05.874+0900 I/SWIFTKEY(  712): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-01 20:28:05.874+0900 W/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
04-01 20:28:05.884+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-01 20:28:05.884+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
04-01 20:28:05.884+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-01 20:28:05.884+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
04-01 20:28:05.884+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
04-01 20:28:05.894+0900 I/UXT     ( 8479): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-01 20:28:05.924+0900 I/SWIFTKEY(  712): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-01 20:28:05.924+0900 W/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
04-01 20:28:05.924+0900 I/MALI    ( 8138): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=8138   close drm_fd=30 
04-01 20:28:05.934+0900 W/CANDIDATE(  858): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 20:28:05.934+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
04-01 20:28:05.934+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:05.944+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 20:28:05.954+0900 E/ISE_MULTI(  858): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 577[0m
04-01 20:28:05.984+0900 E/TBM     ( 8479): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-01 20:28:05.984+0900 I/MALI    ( 8479): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=8479   open drm_fd=30 
04-01 20:28:06.014+0900 I/ISE_MULTI(  858): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-01 20:28:06.134+0900 W/CANDIDATE(  858): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.144+0900 E/EFL     ( 8479): edje<8479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 20:28:06.144+0900 E/EFL     ( 8479): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.144+0900 E/EFL     ( 8479): edje<8479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 20:28:06.144+0900 E/EFL     ( 8479): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 20:28:06.144+0900 E/EFL     ( 8479): edje<8479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-01 20:28:06.144+0900 E/EFL     ( 8479): By the power of Grayskull, your previous Embryo stack is now broken!
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.144+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.154+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.154+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 20:28:06.154+0900 I/ISE_MULTI(  858): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
04-01 20:28:06.154+0900 W/CANDIDATE(  858): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.164+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 20:28:06.174+0900 W/CANDIDATE(  858): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 20:28:06.174+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8138 pgid = 8138
04-01 20:28:06.174+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(143) > dead_pid(8138)
04-01 20:28:06.174+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 20:28:06.184+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(6642) status(0)
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:06.184+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 20:28:06.214+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-01 20:28:06.214+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-01 20:28:06.214+0900 E/AUL_PAD ( 1508): launchpad.c: main(698) > error reading sigchld info
04-01 20:28:06.214+0900 I/ESD     (  913): esd_main.c: __esd_app_dead_handler(1773) > pid: 8138
04-01 20:28:06.214+0900 I/Tizen::App( 1247): (243) > App[com.samsung.task-mgr] pid[8138] terminate event is forwarded
04-01 20:28:06.214+0900 I/Tizen::System( 1247): (256) > osp.accessorymanager.service provider is found.
04-01 20:28:06.214+0900 I/Tizen::System( 1247): (196) > Accessory Owner is removed [com.samsung.task-mgr, 8138, ]
04-01 20:28:06.214+0900 I/Tizen::System( 1247): (256) > osp.system.service provider is found.
04-01 20:28:06.214+0900 I/Tizen::App( 1247): (506) > TerminatedApp(com.samsung.task-mgr)
04-01 20:28:06.214+0900 I/Tizen::App( 1247): (512) > Not registered pid(8138)
04-01 20:28:06.214+0900 I/Tizen::System( 1247): (246) > Terminated app [com.samsung.task-mgr]
04-01 20:28:06.214+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 20:28:06.214+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8138
04-01 20:28:06.214+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8138
04-01 20:28:06.214+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.705
04-01 20:28:06.224+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 20:28:06.224+0900 I/Tizen::App( 1247): (782) > Finished invoking application event listener for com.samsung.task-mgr, 8138.
04-01 20:28:06.284+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-01 20:28:06.334+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-01 20:28:06.334+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x2800003 FAILED!
04-01 20:28:07.175+0900 E/EFL     ( 6642): ecore_x<6642> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=22695937
04-01 20:28:07.185+0900 I/APP_CORE( 6825): appcore-efl.c: __do_app(514) > [APP 6825] Event: MEM_FLUSH State: PAUSED
04-01 20:28:07.465+0900 E/EFL     ( 6642): ecore_x<6642> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=22696236
04-01 20:28:08.737+0900 E/EFL     ( 6642): ecore_x<6642> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=22697486
04-01 20:28:08.737+0900 E/EFL     ( 6642): ecore_x<6642> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=22697506
04-01 20:28:08.747+0900 I/ISE_MULTI(  858): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
04-01 20:28:08.757+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x3400002 FAILED!
04-01 20:28:08.757+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
04-01 20:28:08.927+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
04-01 20:28:08.937+0900 I/SWIFTKEY(  712): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
04-01 20:28:08.937+0900 W/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
04-01 20:28:08.937+0900 W/CANDIDATE(  858): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.947+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.957+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.957+0900 W/CANDIDATE(  858): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
04-01 20:28:08.957+0900 W/CANDIDATE(  858): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
04-01 20:28:09.017+0900 I/SWIFTKEY(  712): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
04-01 20:28:09.347+0900 I/APP_CORE(  878): appcore-efl.c: __do_app(514) > [APP 878] Event: MEM_FLUSH State: PAUSED
04-01 20:28:10.148+0900 E/EFL     ( 6642): ecore_x<6642> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=22698920
04-01 20:28:10.148+0900 I/MY_LOG  ( 6642): Button pressed
04-01 20:28:10.228+0900 E/EFL     ( 6642): ecore_x<6642> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=22698998
04-01 20:28:10.228+0900 I/ISE_MULTI(  858): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
04-01 20:28:10.238+0900 I/SWIFTKEY(  712): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-01 20:28:10.268+0900 I/MY_LOG  ( 6642): Button unpressed
04-01 20:28:10.328+0900 E/EFL     ( 6642): elementary<6642> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-01 20:28:10.839+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 20:28:11.469+0900 E/EFL     ( 6642): ecore_x<6642> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=22700239
04-01 20:28:11.469+0900 I/MY_LOG  ( 6642): Button pressed
04-01 20:28:11.569+0900 E/EFL     ( 6642): ecore_x<6642> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=22700339
04-01 20:28:11.569+0900 I/MY_LOG  ( 6642): Button unpressed
04-01 20:28:12.681+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 20:28:12.701+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(878) status(3)
04-01 20:28:12.701+0900 W/AUL_AMD (  605): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 20:28:12.701+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-01 20:28:12.701+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(878)
04-01 20:28:12.701+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 878, appid: com.samsung.homescreen, status: fg
04-01 20:28:12.701+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6642 pgid = 6642
04-01 20:28:12.711+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(143) > dead_pid(6642)
04-01 20:28:12.731+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(878) status(0)
04-01 20:28:12.761+0900 I/AUL_PAD ( 1508): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-01 20:28:12.761+0900 I/AUL_PAD ( 1508): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-01 20:28:12.761+0900 E/AUL_PAD ( 1508): launchpad.c: main(698) > error reading sigchld info
04-01 20:28:12.761+0900 I/ESD     (  913): esd_main.c: __esd_app_dead_handler(1773) > pid: 6642
04-01 20:28:12.761+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6642
04-01 20:28:12.761+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6642
04-01 20:28:12.761+0900 I/Tizen::App( 1247): (243) > App[org.example.client] pid[6642] terminate event is forwarded
04-01 20:28:12.761+0900 I/Tizen::System( 1247): (256) > osp.accessorymanager.service provider is found.
04-01 20:28:12.761+0900 I/Tizen::System( 1247): (196) > Accessory Owner is removed [org.example.client, 6642, ]
04-01 20:28:12.761+0900 I/Tizen::System( 1247): (256) > osp.system.service provider is found.
04-01 20:28:12.761+0900 I/Tizen::App( 1247): (506) > TerminatedApp(org.example.client)
04-01 20:28:12.761+0900 I/Tizen::App( 1247): (512) > Not registered pid(6642)
04-01 20:28:12.761+0900 I/Tizen::System( 1247): (246) > Terminated app [org.example.client]
04-01 20:28:12.761+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 20:28:12.771+0900 I/APP_CORE(  878): appcore-efl.c: __do_app(514) > [APP 878] Event: RESUME State: PAUSED
04-01 20:28:12.771+0900 I/CAPI_APPFW_APPLICATION(  878): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 20:28:12.771+0900 E/cluster-home(  878): homescreen.cpp: OnResume(233) >  app resume
04-01 20:28:12.771+0900 E/RESOURCED(  685): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.706
04-01 20:28:12.771+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 20:28:12.781+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 20:28:12.781+0900 I/Tizen::App( 1247): (782) > Finished invoking application event listener for org.example.client, 6642.
04-01 20:28:12.781+0900 E/weather-widget( 1420): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-01 20:28:12.811+0900 E/weather-widget( 1420): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-01 20:28:12.821+0900 I/Tizen::System( 1247): (259) > Active app [com.samsun], current [org.exampl] 
04-01 20:28:12.821+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 20:28:12.831+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 20:28:12.831+0900 W/CRASH_MANAGER( 8489): worker.c: worker_job(1199) > 1106642636c69149104609
